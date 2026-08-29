using System;
using System.Collections;

namespace Mono.CompilerServices.SymbolWriter
{
	public class SourceMethodBuilder
	{
		private ArrayList _locals;

		private ArrayList _blocks;

		private ArrayList _scope_vars;

		private Stack _block_stack;

		private string _real_name;

		private IMethodDef _method;

		private ICompileUnit _comp_unit;

		private int _ns_id;

		private LineNumberEntry[] method_lines;

		private int method_lines_pos;

		public CodeBlockEntry[] Blocks
		{
			get
			{
				if (_blocks == null)
				{
					return new CodeBlockEntry[0];
				}
				CodeBlockEntry[] array = new CodeBlockEntry[_blocks.Count];
				_blocks.CopyTo(array, 0);
				return array;
			}
		}

		public CodeBlockEntry CurrentBlock
		{
			get
			{
				if (_block_stack != null && _block_stack.Count > 0)
				{
					return (CodeBlockEntry)_block_stack.Peek();
				}
				return null;
			}
		}

		public LocalVariableEntry[] Locals
		{
			get
			{
				if (_locals == null)
				{
					return new LocalVariableEntry[0];
				}
				LocalVariableEntry[] array = new LocalVariableEntry[_locals.Count];
				_locals.CopyTo(array, 0);
				return array;
			}
		}

		public ScopeVariable[] ScopeVariables
		{
			get
			{
				if (_scope_vars == null)
				{
					return new ScopeVariable[0];
				}
				ScopeVariable[] array = new ScopeVariable[_scope_vars.Count];
				_scope_vars.CopyTo(array);
				return array;
			}
		}

		public string RealMethodName
		{
			get
			{
				return _real_name;
			}
		}

		public ICompileUnit SourceFile
		{
			get
			{
				return _comp_unit;
			}
		}

		public IMethodDef Method
		{
			get
			{
				return _method;
			}
		}

		public SourceMethodBuilder(ICompileUnit comp_unit, int ns_id, IMethodDef method)
		{
			_comp_unit = comp_unit;
			_method = method;
			_ns_id = ns_id;
			method_lines = new LineNumberEntry[32];
		}

		public void MarkSequencePoint(int offset, SourceFileEntry file, int line, int column, bool is_hidden)
		{
			if (method_lines_pos == method_lines.Length)
			{
				LineNumberEntry[] sourceArray = method_lines;
				method_lines = new LineNumberEntry[method_lines.Length * 2];
				Array.Copy(sourceArray, method_lines, method_lines_pos);
			}
			int file2 = ((file != null) ? file.Index : 0);
			method_lines[method_lines_pos++] = new LineNumberEntry(file2, line, offset, is_hidden);
		}

		public void StartBlock(CodeBlockEntry.Type type, int start_offset)
		{
			if (_block_stack == null)
			{
				_block_stack = new Stack();
			}
			if (_blocks == null)
			{
				_blocks = new ArrayList();
			}
			int parent = ((CurrentBlock == null) ? (-1) : CurrentBlock.Index);
			CodeBlockEntry codeBlockEntry = new CodeBlockEntry(_blocks.Count + 1, parent, type, start_offset);
			_block_stack.Push(codeBlockEntry);
			_blocks.Add(codeBlockEntry);
		}

		public void EndBlock(int end_offset)
		{
			CodeBlockEntry codeBlockEntry = (CodeBlockEntry)_block_stack.Pop();
			codeBlockEntry.Close(end_offset);
		}

		public void AddLocal(int index, string name)
		{
			if (_locals == null)
			{
				_locals = new ArrayList();
			}
			int block = ((CurrentBlock != null) ? CurrentBlock.Index : 0);
			_locals.Add(new LocalVariableEntry(index, name, block));
		}

		public void AddScopeVariable(int scope, int index)
		{
			if (_scope_vars == null)
			{
				_scope_vars = new ArrayList();
			}
			_scope_vars.Add(new ScopeVariable(scope, index));
		}

		public void SetRealMethodName(string name)
		{
			_real_name = name;
		}

		public void DefineMethod(MonoSymbolFile file)
		{
			LineNumberEntry[] array = new LineNumberEntry[method_lines_pos];
			Array.Copy(method_lines, array, method_lines_pos);
			MethodEntry entry = new MethodEntry(file, _comp_unit.Entry, _method.Token, ScopeVariables, Locals, array, Blocks, RealMethodName, (MethodEntry.Flags)0, _ns_id);
			file.AddMethod(entry);
		}
	}
}
