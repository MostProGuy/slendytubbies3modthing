using System;
using UnityEngine;

public abstract class FKFPGACGHKG
{
	private int GAEBNEMKPEF;

	private int PMNCAIAFDKE;

	private DJAMDIAJGMD[,] FHPPGKMOEGO;

	public int LADIIIDJJGE
	{
		get
		{
			return GAEBNEMKPEF;
		}
	}

	public int BDBHLPFOGAN
	{
		get
		{
			return PMNCAIAFDKE;
		}
	}

	public FKFPGACGHKG(int HJFFHOBLMCI, int LMOIAHCCJAB)
	{
		GAEBNEMKPEF = Mathf.Abs(HJFFHOBLMCI);
		PMNCAIAFDKE = Mathf.Abs(LMOIAHCCJAB);
		if (GAEBNEMKPEF == 0)
		{
			GAEBNEMKPEF = 1;
		}
		if (PMNCAIAFDKE == 0)
		{
			PMNCAIAFDKE = 1;
		}
		FHPPGKMOEGO = new DJAMDIAJGMD[HJFFHOBLMCI, LMOIAHCCJAB];
		for (int i = 0; i < HJFFHOBLMCI; i++)
		{
			for (int j = 0; j < LMOIAHCCJAB; j++)
			{
				FHPPGKMOEGO[i, j] = new DJAMDIAJGMD();
			}
		}
	}

	public abstract void GenerateMaze();

	public DJAMDIAJGMD GetMazeCell(int FPIFBOBBJGG, int NMBEPDHCKEJ)
	{
		if (FPIFBOBBJGG >= 0 && NMBEPDHCKEJ >= 0 && FPIFBOBBJGG < GAEBNEMKPEF && NMBEPDHCKEJ < PMNCAIAFDKE)
		{
			return FHPPGKMOEGO[FPIFBOBBJGG, NMBEPDHCKEJ];
		}
		Debug.Log(FPIFBOBBJGG + " " + NMBEPDHCKEJ);
		throw new ArgumentOutOfRangeException();
	}

	protected void SetMazeCell(int FPIFBOBBJGG, int NMBEPDHCKEJ, DJAMDIAJGMD JNCMJBIKBCF)
	{
		if (FPIFBOBBJGG >= 0 && NMBEPDHCKEJ >= 0 && FPIFBOBBJGG < GAEBNEMKPEF && NMBEPDHCKEJ < PMNCAIAFDKE)
		{
			FHPPGKMOEGO[FPIFBOBBJGG, NMBEPDHCKEJ] = JNCMJBIKBCF;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}
}
