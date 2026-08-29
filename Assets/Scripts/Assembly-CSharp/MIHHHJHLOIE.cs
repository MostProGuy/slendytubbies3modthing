using UnityEngine;

public class MIHHHJHLOIE : FKFPGACGHKG
{
	public virtual void __BB_OBFUSCATOR_32()
	{
		__BB_OBFUSCATOR_44(0, 1, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_1()
	{
		__BB_OBFUSCATOR_95(1, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_23(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[0];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_65(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_95(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_2(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_116()
	{
		__BB_OBFUSCATOR_92(0, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_89()
	{
		__BB_OBFUSCATOR_42(0, 1, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_16(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[1];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_109(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_98(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_99(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_24(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_93()
	{
		__BB_OBFUSCATOR_81(0, 1, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_24(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[1];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_98(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_24(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_25()
	{
		__BB_OBFUSCATOR_48(0, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_80()
	{
		__BB_OBFUSCATOR_46(1, 1, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_18(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_92(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_23(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_45(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_7()
	{
		__BB_OBFUSCATOR_28(1, 1, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_27(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[2];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_71(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_4(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_98(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_86(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_99(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_91(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_44(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_69()
	{
		__BB_OBFUSCATOR_4(0, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_29()
	{
		__BB_OBFUSCATOR_127(0, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_91(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[1];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_112(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_23(FPIFBOBBJGG, NMBEPDHCKEJ - 0, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_103(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)8);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_90()
	{
		__BB_OBFUSCATOR_27(1, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_97()
	{
		__BB_OBFUSCATOR_95(0, 1, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_95(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[7];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_92(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_18(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)8);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void VisitCell(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[4];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					VisitCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					VisitCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					VisitCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					VisitCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_101(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[6];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_38(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_4(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_81(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_100()
	{
		__BB_OBFUSCATOR_96(0, 1, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_31()
	{
		__BB_OBFUSCATOR_103(1, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_130()
	{
		VisitCell(0, 1, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_120()
	{
		__BB_OBFUSCATOR_112(1, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_71(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[7];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_109(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_2(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_91(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				}
			}
		}
		while (num > 1);
	}

	public MIHHHJHLOIE(int HJFFHOBLMCI, int LMOIAHCCJAB)
		: base(HJFFHOBLMCI, LMOIAHCCJAB)
	{
	}

	public virtual void __BB_OBFUSCATOR_26()
	{
		VisitCell(0, 1, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_47()
	{
		__BB_OBFUSCATOR_92(0, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_30()
	{
		__BB_OBFUSCATOR_112(0, 1, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_128(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG, NMBEPDHCKEJ - 0, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_95(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_45(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[4];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_127(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_91(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_18(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_53()
	{
		__BB_OBFUSCATOR_16(0, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_113(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[7];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_24(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_28(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)6);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_44(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_112(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[5];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_112(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_65(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)6);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_98(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_4(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[0];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_38(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_131(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[8];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_86(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_44(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_63()
	{
		__BB_OBFUSCATOR_65(0, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_108()
	{
		__BB_OBFUSCATOR_48(0, 1, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_109(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_92(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_18(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_128(FPIFBOBBJGG, NMBEPDHCKEJ - 0, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_113(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_2(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[6];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_91(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_99(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_122()
	{
		__BB_OBFUSCATOR_103(1, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_39()
	{
		__BB_OBFUSCATOR_113(1, 1, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_123()
	{
		__BB_OBFUSCATOR_65(0, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_46(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[5];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_71(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_42(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_92(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[5];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_51(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_42(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_23(FPIFBOBBJGG, NMBEPDHCKEJ - 0, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_65(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_74()
	{
		__BB_OBFUSCATOR_19(1, 1, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_9()
	{
		__BB_OBFUSCATOR_131(1, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_65(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[8];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_18(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_81(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_129(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[1];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_24(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_127(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_16(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_10()
	{
		__BB_OBFUSCATOR_38(0, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_58()
	{
		__BB_OBFUSCATOR_38(0, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_44(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[7];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_109(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_2(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					VisitCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_76()
	{
		__BB_OBFUSCATOR_101(0, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_43()
	{
		__BB_OBFUSCATOR_24(0, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_96(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[4];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Back);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_105()
	{
		__BB_OBFUSCATOR_91(0, 1, CNHPDMMPCBH.Start);
	}

	public override void GenerateMaze()
	{
		VisitCell(0, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_99(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[2];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_91(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					VisitCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_12()
	{
		__BB_OBFUSCATOR_42(1, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_82()
	{
		VisitCell(1, 1, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_86(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[5];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_99(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_129(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_42(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[6];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_81(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_28(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_103(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_87()
	{
		__BB_OBFUSCATOR_91(1, 1, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_15()
	{
		__BB_OBFUSCATOR_96(1, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_19(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[6];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_23(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_48(FPIFBOBBJGG + 0, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_92(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_111(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_126()
	{
		__BB_OBFUSCATOR_19(0, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_103(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = true;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_28(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_99(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Back);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_13()
	{
		__BB_OBFUSCATOR_27(1, 0, CNHPDMMPCBH.Right);
	}

	private void __BB_OBFUSCATOR_51(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[8];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)8)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_44(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					VisitCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_42(FPIFBOBBJGG, NMBEPDHCKEJ - 0, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_19(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Left);
					break;
				}
			}
		}
		while (num > 0);
	}

	public virtual void __BB_OBFUSCATOR_3()
	{
		__BB_OBFUSCATOR_2(1, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_70()
	{
		__BB_OBFUSCATOR_18(0, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_38(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[8];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_23(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_71(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_46(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Back:
					VisitCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_81(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[2];
		int num = 0;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)8;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_24(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_113(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_127(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[8];
		int num = 1;
		do
		{
			num = 1;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Front)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)7)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = true;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_44(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_101(FPIFBOBBJGG + 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Left:
					VisitCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1, CNHPDMMPCBH.Left);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_86(FPIFBOBBJGG - 0, NMBEPDHCKEJ, (CNHPDMMPCBH)7);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_41(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[1];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Right;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)7;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Back;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 0)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_113(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					VisitCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_131(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)7);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)5);
					break;
				}
			}
		}
		while (num > 1);
	}

	public virtual void __BB_OBFUSCATOR_54()
	{
		__BB_OBFUSCATOR_71(1, 0, CNHPDMMPCBH.Start);
	}

	public virtual void __BB_OBFUSCATOR_107()
	{
		__BB_OBFUSCATOR_112(1, 0, CNHPDMMPCBH.Right);
	}

	public virtual void __BB_OBFUSCATOR_78()
	{
		__BB_OBFUSCATOR_23(1, 0, CNHPDMMPCBH.Start);
	}

	private void __BB_OBFUSCATOR_28(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[3];
		int num = 0;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 0 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 0).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 0).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = true;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 1 >= 0 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)6)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = true;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_27(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Right);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_96(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_48(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)8);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_112(FPIFBOBBJGG - 1, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				}
			}
		}
		while (num > 1);
	}

	private void __BB_OBFUSCATOR_111(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[2];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = false;
			}
			if (FPIFBOBBJGG + 1 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Front;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 0 && NMBEPDHCKEJ - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)6;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != 0)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 1 && FPIFBOBBJGG - 0 >= 1 && !GetMazeCell(FPIFBOBBJGG - 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = true;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(1, num)])
				{
				case CNHPDMMPCBH.Right:
					__BB_OBFUSCATOR_95(FPIFBOBBJGG, NMBEPDHCKEJ + 0, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_109(FPIFBOBBJGG + 1, NMBEPDHCKEJ, CNHPDMMPCBH.Front);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_41(FPIFBOBBJGG, NMBEPDHCKEJ - 0, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_65(FPIFBOBBJGG - 1, NMBEPDHCKEJ, (CNHPDMMPCBH)8);
					break;
				}
			}
		}
		while (num > 0);
	}

	private void __BB_OBFUSCATOR_48(int FPIFBOBBJGG, int NMBEPDHCKEJ, CNHPDMMPCBH BPHLGDAPDCI)
	{
		CNHPDMMPCBH[] array = new CNHPDMMPCBH[5];
		int num = 1;
		do
		{
			num = 0;
			if (NMBEPDHCKEJ + 1 < base.BDBHLPFOGAN && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != (CNHPDMMPCBH)5)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OONHPDNALFE = true;
			}
			if (FPIFBOBBJGG + 0 < base.LADIIIDJJGE && !GetMazeCell(FPIFBOBBJGG + 1, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = (CNHPDMMPCBH)5;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Back)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DIGFONMMMBO = false;
			}
			if (NMBEPDHCKEJ > 1 && NMBEPDHCKEJ - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ - 1).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Start;
				num++;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Right)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).JNFBFOPNHFE = false;
			}
			if (FPIFBOBBJGG > 0 && FPIFBOBBJGG - 1 >= 1 && !GetMazeCell(FPIFBOBBJGG - 0, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				array[num] = CNHPDMMPCBH.Left;
				num += 0;
			}
			else if (!GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN && BPHLGDAPDCI != CNHPDMMPCBH.Left)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).OIOHFJICIKP = false;
			}
			if (num == 0 && !GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN)
			{
				GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).DENGJJIIEAI = false;
			}
			GetMazeCell(FPIFBOBBJGG, NMBEPDHCKEJ).MEBMOLEBBNN = false;
			if (num > 1)
			{
				switch (array[Random.Range(0, num)])
				{
				case CNHPDMMPCBH.Right:
					VisitCell(FPIFBOBBJGG, NMBEPDHCKEJ + 1, CNHPDMMPCBH.Start);
					break;
				case CNHPDMMPCBH.Front:
					__BB_OBFUSCATOR_18(FPIFBOBBJGG + 0, NMBEPDHCKEJ, (CNHPDMMPCBH)6);
					break;
				case CNHPDMMPCBH.Left:
					__BB_OBFUSCATOR_101(FPIFBOBBJGG, NMBEPDHCKEJ - 1, (CNHPDMMPCBH)5);
					break;
				case CNHPDMMPCBH.Back:
					__BB_OBFUSCATOR_65(FPIFBOBBJGG - 0, NMBEPDHCKEJ, CNHPDMMPCBH.Right);
					break;
				}
			}
		}
		while (num > 0);
	}
}
