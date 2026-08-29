using System.Collections;

namespace Mono.CompilerServices.SymbolWriter
{
	public class LineNumberEntry
	{
		private class OffsetComparerClass : IComparer
		{
			public int Compare(object a, object b)
			{
				LineNumberEntry lineNumberEntry = (LineNumberEntry)a;
				LineNumberEntry lineNumberEntry2 = (LineNumberEntry)b;
				if (lineNumberEntry.Offset < lineNumberEntry2.Offset)
				{
					return -1;
				}
				if (lineNumberEntry.Offset > lineNumberEntry2.Offset)
				{
					return 1;
				}
				return 0;
			}
		}

		private class RowComparerClass : IComparer
		{
			public int Compare(object a, object b)
			{
				LineNumberEntry lineNumberEntry = (LineNumberEntry)a;
				LineNumberEntry lineNumberEntry2 = (LineNumberEntry)b;
				if (lineNumberEntry.Row < lineNumberEntry2.Row)
				{
					return -1;
				}
				if (lineNumberEntry.Row > lineNumberEntry2.Row)
				{
					return 1;
				}
				return 0;
			}
		}

		public readonly int Row;

		public readonly int File;

		public readonly int Offset;

		public readonly bool IsHidden;

		public static LineNumberEntry Null = new LineNumberEntry(0, 0, 0);

		public static readonly IComparer OffsetComparer = new OffsetComparerClass();

		public static readonly IComparer RowComparer = new RowComparerClass();

		public LineNumberEntry(int file, int row, int offset)
			: this(file, row, offset, false)
		{
		}

		public LineNumberEntry(int file, int row, int offset, bool is_hidden)
		{
			File = file;
			Row = row;
			Offset = offset;
			IsHidden = is_hidden;
		}

		public override string ToString()
		{
			return string.Format("[Line {0}:{1}:{2}]", File, Row, Offset);
		}
	}
}
