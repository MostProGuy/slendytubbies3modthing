using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace Mono.CompilerServices.SymbolWriter
{
	public class MonoSymbolFile : IDisposable
	{
		private ArrayList methods = new ArrayList();

		private ArrayList sources = new ArrayList();

		private ArrayList comp_units = new ArrayList();

		private Hashtable type_hash = new Hashtable();

		private Hashtable anonymous_scopes;

		private OffsetTable ot;

		private int last_type_index;

		private int last_method_index;

		private int last_namespace_index;

		public readonly string FileName = "<dynamic>";

		public readonly int MajorVersion = 50;

		public readonly int MinorVersion;

		public int NumLineNumbers;

		private MyBinaryReader reader;

		private Hashtable source_file_hash;

		private Hashtable compile_unit_hash;

		private ArrayList method_list;

		private Hashtable method_token_hash;

		private Hashtable source_name_hash;

		private Guid guid;

		internal int LineNumberCount;

		internal int LocalCount;

		internal int StringSize;

		internal int LineNumberSize;

		internal int ExtendedLineNumberSize;

		public int CompileUnitCount
		{
			get
			{
				return ot.CompileUnitCount;
			}
		}

		public int SourceCount
		{
			get
			{
				return ot.SourceCount;
			}
		}

		public int MethodCount
		{
			get
			{
				return ot.MethodCount;
			}
		}

		public int TypeCount
		{
			get
			{
				return ot.TypeCount;
			}
		}

		public int AnonymousScopeCount
		{
			get
			{
				return ot.AnonymousScopeCount;
			}
		}

		public int NamespaceCount
		{
			get
			{
				return last_namespace_index;
			}
		}

		public Guid Guid
		{
			get
			{
				return guid;
			}
		}

		public OffsetTable OffsetTable
		{
			get
			{
				return ot;
			}
		}

		public SourceFileEntry[] Sources
		{
			get
			{
				if (reader == null)
				{
					throw new InvalidOperationException();
				}
				SourceFileEntry[] array = new SourceFileEntry[SourceCount];
				for (int i = 0; i < SourceCount; i++)
				{
					array[i] = GetSourceFile(i + 1);
				}
				return array;
			}
		}

		public CompileUnitEntry[] CompileUnits
		{
			get
			{
				if (reader == null)
				{
					throw new InvalidOperationException();
				}
				CompileUnitEntry[] array = new CompileUnitEntry[CompileUnitCount];
				for (int i = 0; i < CompileUnitCount; i++)
				{
					array[i] = GetCompileUnit(i + 1);
				}
				return array;
			}
		}

		public MethodEntry[] Methods
		{
			get
			{
				//Discarded unreachable code: IL_003f
				if (reader == null)
				{
					throw new InvalidOperationException();
				}
				lock (this)
				{
					read_methods();
					MethodEntry[] array = new MethodEntry[MethodCount];
					method_list.CopyTo(array, 0);
					return array;
				}
			}
		}

		internal MyBinaryReader BinaryReader
		{
			get
			{
				if (reader == null)
				{
					throw new InvalidOperationException();
				}
				return reader;
			}
		}

		internal MonoSymbolFile()
		{
			ot = new OffsetTable();
		}

		private MonoSymbolFile(string filename)
		{
			//Discarded unreachable code: IL_016d
			FileName = filename;
			FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			reader = new MyBinaryReader(stream);
			try
			{
				long num = reader.ReadInt64();
				int num2 = reader.ReadInt32();
				int num3 = reader.ReadInt32();
				if (num != 5037318119232611860L)
				{
					throw new MonoSymbolFileException("Symbol file `{0}' is not a valid Mono symbol file", filename);
				}
				if (num2 != 50)
				{
					throw new MonoSymbolFileException("Symbol file `{0}' has version {1}, but expected {2}", filename, num2, 50);
				}
				if (num3 != 0)
				{
					throw new MonoSymbolFileException("Symbol file `{0}' has version {1}.{2}, but expected {3}.{4}", filename, num2, num3, 50, 0);
				}
				MajorVersion = num2;
				MinorVersion = num3;
				guid = new Guid(reader.ReadBytes(16));
				ot = new OffsetTable(reader, num2, num3);
			}
			catch
			{
				throw new MonoSymbolFileException("Cannot read symbol file `{0}'", filename);
			}
			source_file_hash = new Hashtable();
			compile_unit_hash = new Hashtable();
		}

		protected MonoSymbolFile(string filename, Assembly assembly)
			: this(filename)
		{
			if (assembly != null)
			{
				Module[] modules = assembly.GetModules();
				Guid other = MonoDebuggerSupport.GetGuid(modules[0]);
				CheckGuidMatch(other, filename, assembly.Location);
			}
		}

		internal int AddSource(SourceFileEntry source)
		{
			sources.Add(source);
			return sources.Count;
		}

		internal int AddCompileUnit(CompileUnitEntry entry)
		{
			comp_units.Add(entry);
			return comp_units.Count;
		}

		internal int DefineType(Type type)
		{
			if (type_hash.Contains(type))
			{
				return (int)type_hash[type];
			}
			int num = ++last_type_index;
			type_hash.Add(type, num);
			return num;
		}

		internal void AddMethod(MethodEntry entry)
		{
			methods.Add(entry);
		}

		public MethodEntry DefineMethod(CompileUnitEntry comp_unit, int token, ScopeVariable[] scope_vars, LocalVariableEntry[] locals, LineNumberEntry[] lines, CodeBlockEntry[] code_blocks, string real_name, MethodEntry.Flags flags, int namespace_id)
		{
			if (reader != null)
			{
				throw new InvalidOperationException();
			}
			MethodEntry methodEntry = new MethodEntry(this, comp_unit, token, scope_vars, locals, lines, code_blocks, real_name, flags, namespace_id);
			AddMethod(methodEntry);
			return methodEntry;
		}

		internal void DefineAnonymousScope(int id)
		{
			if (reader != null)
			{
				throw new InvalidOperationException();
			}
			if (anonymous_scopes == null)
			{
				anonymous_scopes = new Hashtable();
			}
			anonymous_scopes.Add(id, new AnonymousScopeEntry(id));
		}

		internal void DefineCapturedVariable(int scope_id, string name, string captured_name, CapturedVariable.CapturedKind kind)
		{
			if (reader != null)
			{
				throw new InvalidOperationException();
			}
			AnonymousScopeEntry anonymousScopeEntry = (AnonymousScopeEntry)anonymous_scopes[scope_id];
			anonymousScopeEntry.AddCapturedVariable(name, captured_name, kind);
		}

		internal void DefineCapturedScope(int scope_id, int id, string captured_name)
		{
			if (reader != null)
			{
				throw new InvalidOperationException();
			}
			AnonymousScopeEntry anonymousScopeEntry = (AnonymousScopeEntry)anonymous_scopes[scope_id];
			anonymousScopeEntry.AddCapturedScope(id, captured_name);
		}

		internal int GetNextTypeIndex()
		{
			return ++last_type_index;
		}

		internal int GetNextMethodIndex()
		{
			return ++last_method_index;
		}

		internal int GetNextNamespaceIndex()
		{
			return ++last_namespace_index;
		}

		private void Write(MyBinaryWriter bw, Guid guid)
		{
			bw.Write(5037318119232611860L);
			bw.Write(MajorVersion);
			bw.Write(MinorVersion);
			bw.Write(guid.ToByteArray());
			long position = bw.BaseStream.Position;
			ot.Write(bw, MajorVersion, MinorVersion);
			methods.Sort();
			for (int i = 0; i < methods.Count; i++)
			{
				((MethodEntry)methods[i]).Index = i + 1;
			}
			ot.DataSectionOffset = (int)bw.BaseStream.Position;
			foreach (SourceFileEntry source in sources)
			{
				source.WriteData(bw);
			}
			foreach (CompileUnitEntry comp_unit in comp_units)
			{
				comp_unit.WriteData(bw);
			}
			foreach (MethodEntry method in methods)
			{
				method.WriteData(this, bw);
			}
			ot.DataSectionSize = (int)bw.BaseStream.Position - ot.DataSectionOffset;
			ot.MethodTableOffset = (int)bw.BaseStream.Position;
			for (int j = 0; j < methods.Count; j++)
			{
				MethodEntry methodEntry2 = (MethodEntry)methods[j];
				methodEntry2.Write(bw);
			}
			ot.MethodTableSize = (int)bw.BaseStream.Position - ot.MethodTableOffset;
			ot.SourceTableOffset = (int)bw.BaseStream.Position;
			for (int k = 0; k < sources.Count; k++)
			{
				SourceFileEntry sourceFileEntry2 = (SourceFileEntry)sources[k];
				sourceFileEntry2.Write(bw);
			}
			ot.SourceTableSize = (int)bw.BaseStream.Position - ot.SourceTableOffset;
			ot.CompileUnitTableOffset = (int)bw.BaseStream.Position;
			for (int l = 0; l < comp_units.Count; l++)
			{
				CompileUnitEntry compileUnitEntry2 = (CompileUnitEntry)comp_units[l];
				compileUnitEntry2.Write(bw);
			}
			ot.CompileUnitTableSize = (int)bw.BaseStream.Position - ot.CompileUnitTableOffset;
			ot.AnonymousScopeCount = ((anonymous_scopes != null) ? anonymous_scopes.Count : 0);
			ot.AnonymousScopeTableOffset = (int)bw.BaseStream.Position;
			if (anonymous_scopes != null)
			{
				foreach (AnonymousScopeEntry value in anonymous_scopes.Values)
				{
					value.Write(bw);
				}
			}
			ot.AnonymousScopeTableSize = (int)bw.BaseStream.Position - ot.AnonymousScopeTableOffset;
			ot.TypeCount = last_type_index;
			ot.MethodCount = methods.Count;
			ot.SourceCount = sources.Count;
			ot.CompileUnitCount = comp_units.Count;
			ot.TotalFileSize = (int)bw.BaseStream.Position;
			bw.Seek((int)position, SeekOrigin.Begin);
			ot.Write(bw, MajorVersion, MinorVersion);
			bw.Seek(0, SeekOrigin.End);
		}

		public void CreateSymbolFile(Guid guid, FileStream fs)
		{
			if (reader != null)
			{
				throw new InvalidOperationException();
			}
			Write(new MyBinaryWriter(fs), guid);
		}

		private void CheckGuidMatch(Guid other, string filename, string assembly)
		{
			if (other == guid)
			{
				return;
			}
			throw new MonoSymbolFileException("Symbol file `{0}' does not match assembly `{1}'", filename, assembly);
		}

		public static MonoSymbolFile ReadSymbolFile(Assembly assembly)
		{
			string location = assembly.Location;
			string filename = location + ".mdb";
			return new MonoSymbolFile(filename, assembly);
		}

		public static MonoSymbolFile ReadSymbolFile(string mdbFilename)
		{
			return new MonoSymbolFile(mdbFilename, null);
		}

		public SourceFileEntry GetSourceFile(int index)
		{
			//Discarded unreachable code: IL_00c9
			if (index < 1 || index > ot.SourceCount)
			{
				throw new ArgumentException();
			}
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				SourceFileEntry sourceFileEntry = (SourceFileEntry)source_file_hash[index];
				if (sourceFileEntry != null)
				{
					return sourceFileEntry;
				}
				long position = reader.BaseStream.Position;
				reader.BaseStream.Position = ot.SourceTableOffset + SourceFileEntry.Size * (index - 1);
				sourceFileEntry = new SourceFileEntry(this, reader);
				source_file_hash.Add(index, sourceFileEntry);
				reader.BaseStream.Position = position;
				return sourceFileEntry;
			}
		}

		public CompileUnitEntry GetCompileUnit(int index)
		{
			//Discarded unreachable code: IL_00c9
			if (index < 1 || index > ot.CompileUnitCount)
			{
				throw new ArgumentException();
			}
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				CompileUnitEntry compileUnitEntry = (CompileUnitEntry)compile_unit_hash[index];
				if (compileUnitEntry != null)
				{
					return compileUnitEntry;
				}
				long position = reader.BaseStream.Position;
				reader.BaseStream.Position = ot.CompileUnitTableOffset + CompileUnitEntry.Size * (index - 1);
				compileUnitEntry = new CompileUnitEntry(this, reader);
				compile_unit_hash.Add(index, compileUnitEntry);
				reader.BaseStream.Position = position;
				return compileUnitEntry;
			}
		}

		private void read_methods()
		{
			lock (this)
			{
				if (method_token_hash == null)
				{
					method_token_hash = new Hashtable();
					method_list = new ArrayList();
					long position = reader.BaseStream.Position;
					reader.BaseStream.Position = ot.MethodTableOffset;
					for (int i = 0; i < MethodCount; i++)
					{
						MethodEntry methodEntry = new MethodEntry(this, reader, i + 1);
						method_token_hash.Add(methodEntry.Token, methodEntry);
						method_list.Add(methodEntry);
					}
					reader.BaseStream.Position = position;
				}
			}
		}

		public MethodEntry GetMethodByToken(int token)
		{
			//Discarded unreachable code: IL_003b
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				read_methods();
				return (MethodEntry)method_token_hash[token];
			}
		}

		public MethodEntry GetMethod(int index)
		{
			//Discarded unreachable code: IL_0056
			if (index < 1 || index > ot.MethodCount)
			{
				throw new ArgumentException();
			}
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				read_methods();
				return (MethodEntry)method_list[index - 1];
			}
		}

		public int FindSource(string file_name)
		{
			//Discarded unreachable code: IL_0094
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				if (source_name_hash == null)
				{
					source_name_hash = new Hashtable();
					for (int i = 0; i < ot.SourceCount; i++)
					{
						SourceFileEntry sourceFile = GetSourceFile(i + 1);
						source_name_hash.Add(sourceFile.FileName, i);
					}
				}
				object obj = source_name_hash[file_name];
				if (obj == null)
				{
					return -1;
				}
				return (int)obj;
			}
		}

		public AnonymousScopeEntry GetAnonymousScope(int id)
		{
			//Discarded unreachable code: IL_00c2
			if (reader == null)
			{
				throw new InvalidOperationException();
			}
			lock (this)
			{
				if (anonymous_scopes != null)
				{
					return (AnonymousScopeEntry)anonymous_scopes[id];
				}
				anonymous_scopes = new Hashtable();
				reader.BaseStream.Position = ot.AnonymousScopeTableOffset;
				for (int i = 0; i < ot.AnonymousScopeCount; i++)
				{
					AnonymousScopeEntry anonymousScopeEntry = new AnonymousScopeEntry(reader);
					anonymous_scopes.Add(anonymousScopeEntry.ID, anonymousScopeEntry);
				}
				return (AnonymousScopeEntry)anonymous_scopes[id];
			}
		}

		public void Dispose()
		{
			Dispose(true);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && reader != null)
			{
				reader.Close();
				reader = null;
			}
		}
	}
}
