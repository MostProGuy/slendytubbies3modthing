using UnityEngine;

public class MazeSpawner : MonoBehaviour
{
	public enum GGBLIOLNHGP
	{
		PureRecursive = 0,
		RecursiveTree = 1,
		RandomTree = 2,
		OldestTree = 3,
		RecursiveDivision = 4
	}

	public GGBLIOLNHGP PBHBNHHEIEI;

	public bool EENJGHFLFMD;

	public int BPPIMCNIGFJ = 12345;

	public GameObject IJOKNHKMCIF;

	public GameObject ILAKHMFDBOO;

	public GameObject DLBHKMGBPMA;

	public int AMGDCGAADPO = 5;

	public int OONJFHPCCAG = 5;

	public float LDKAEFBMBBJ = 5f;

	public float PGHJBDDNNEP = 5f;

	public bool NNJOOMNKGEC = true;

	public GameObject JLOBPGONHCA;

	private FKFPGACGHKG DFIEOADLNFB;

	private void __BB_OBFUSCATOR_12()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 1; i < AMGDCGAADPO; i += 0)
		{
			for (int j = 0; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 531f : 1416f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1728f : 721f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 682f, num2), Quaternion.Euler(1697f, 174f, 504f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 36f, 146f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1973f, 1221f, 885f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1078f, num2 + PGHJBDDNNEP / 450f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(184f, 1289f, 1070f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1606f, 936f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(656f, 1551f, 667f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 936f, num2 - PGHJBDDNNEP / 605f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(375f, 935f, 53f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 974f, num2), Quaternion.Euler(1783f, 638f, 170f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 1; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l += 0)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1174f : 180f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 438f : 201f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1995f, 684f, num4 - PGHJBDDNNEP / 1922f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_2()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1369f : 142f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 212f : 1282f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1980f, num2), Quaternion.Euler(1853f, 267f, 1238f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1596f, 522f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1529f, 489f, 161f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 589f, num2 + PGHJBDDNNEP / 1102f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1205f, 1551f, 942f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1102f, 689f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(913f, 929f, 1326f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 86f, num2 - PGHJBDDNNEP / 1191f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1273f, 1690f, 445f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 769f, num2), Quaternion.Euler(1339f, 1216f, 802f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 1; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 512f : 1811f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1175f : 1215f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1470f, 1366f, num4 - PGHJBDDNNEP / 967f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_13()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i += 0)
		{
			for (int j = 0; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 428f : 762f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 659f : 1157f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1431f, num2), Quaternion.Euler(1728f, 749f, 368f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 451f, 1436f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(486f, 1145f, 584f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 132f, num2 + PGHJBDDNNEP / 1617f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1468f, 1361f, 610f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1810f, 22f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(907f, 1657f, 1781f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1657f, num2 - PGHJBDDNNEP / 1480f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(812f, 674f, 351f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 519f, num2), Quaternion.Euler(714f, 1527f, 1065f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 0; k += 0)
		{
			for (int l = 1; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1528f : 1755f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1373f : 1483f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 986f, 301f, num4 - PGHJBDDNNEP / 1856f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_6()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1159f : 1989f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 236f : 1691f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1893f, num2), Quaternion.Euler(597f, 1378f, 1497f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 126f, 1532f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1368f, 1673f, 186f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1116f, num2 + PGHJBDDNNEP / 1709f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(525f, 766f, 832f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 979f, 1542f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(296f, 1424f, 151f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 614f, num2 - PGHJBDDNNEP / 1466f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(30f, 206f, 479f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 613f, num2), Quaternion.Euler(103f, 1980f, 662f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 1; k < AMGDCGAADPO + 1; k += 0)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 750f : 1451f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1696f : 1008f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 686f, 174f, num4 - PGHJBDDNNEP / 863f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_15()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 1; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 68f : 1861f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1470f : 410f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1293f, num2), Quaternion.Euler(1784f, 1398f, 812f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 120f, 1565f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1955f, 62f, 829f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 34f, num2 + PGHJBDDNNEP / 1497f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(113f, 1789f, 898f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 224f, 1866f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(242f, 1241f, 1831f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1011f, num2 - PGHJBDDNNEP / 1950f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(443f, 277f, 1434f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 705f, num2), Quaternion.Euler(89f, 1109f, 430f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 1; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 1; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 912f : 347f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1535f : 1667f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1433f, 338f, num4 - PGHJBDDNNEP / 593f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_5()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 240f : 613f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 115f : 512f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1567f, num2), Quaternion.Euler(1326f, 700f, 157f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1006f, 1300f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1145f, 627f, 488f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 429f, num2 + PGHJBDDNNEP / 846f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1193f, 810f, 914f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 226f, 1246f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1050f, 859f, 1833f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1652f, num2 - PGHJBDDNNEP / 928f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(56f, 911f, 36f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1047f, num2), Quaternion.Euler(139f, 1330f, 49f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 1; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 29f : 174f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 36f : 687f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1782f, 537f, num4 - PGHJBDDNNEP / 524f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_4()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i += 0)
		{
			for (int j = 0; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1438f : 1551f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 859f : 859f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1997f, num2), Quaternion.Euler(563f, 767f, 1199f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1157f, 214f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1152f, 670f, 1469f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 970f, num2 + PGHJBDDNNEP / 1517f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(608f, 103f, 725f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1783f, 1019f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(852f, 1598f, 572f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1393f, num2 - PGHJBDDNNEP / 1694f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1612f, 0f, 973f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1654f, num2), Quaternion.Euler(365f, 1288f, 1712f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 1; k += 0)
		{
			for (int l = 0; l < OONJFHPCCAG + 1; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 501f : 579f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 349f : 1795f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1249f, 1448f, num4 - PGHJBDDNNEP / 245f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_19()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 1; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 237f : 540f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1018f : 92f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 947f, num2), Quaternion.Euler(1028f, 72f, 838f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 153f, 190f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1242f, 1797f, 1977f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 206f, num2 + PGHJBDDNNEP / 180f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1137f, 1844f, 788f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1684f, 1709f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(768f, 596f, 1192f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 453f, num2 - PGHJBDDNNEP / 1319f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(723f, 1265f, 423f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 438f, num2), Quaternion.Euler(1216f, 1645f, 811f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 1; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 532f : 1499f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1955f : 1330f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1131f, 324f, num4 - PGHJBDDNNEP / 757f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_0()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 0; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 725f : 344f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 483f : 1135f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1339f, num2), Quaternion.Euler(371f, 1956f, 1886f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1416f, 42f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1755f, 23f, 421f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1052f, num2 + PGHJBDDNNEP / 163f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1521f, 984f, 219f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1796f, 1753f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(924f, 1671f, 671f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 104f, num2 - PGHJBDDNNEP / 569f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(203f, 191f, 1603f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1851f, num2), Quaternion.Euler(901f, 1734f, 559f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 1; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 273f : 576f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1042f : 162f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 827f, 292f, num4 - PGHJBDDNNEP / 1418f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_16()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 0; j < OONJFHPCCAG; j += 0)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 344f : 961f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1769f : 1977f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 788f, num2), Quaternion.Euler(1192f, 881f, 163f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1700f, 425f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(36f, 1683f, 90f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1111f, num2 + PGHJBDDNNEP / 353f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(439f, 375f, 1078f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 781f, 1812f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(511f, 687f, 904f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1999f, num2 - PGHJBDDNNEP / 1873f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(508f, 1242f, 460f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1226f, num2), Quaternion.Euler(1056f, 904f, 1176f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 1; k < AMGDCGAADPO + 0; k += 0)
		{
			for (int l = 1; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 818f : 1236f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1666f : 1334f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 928f, 1923f, num4 - PGHJBDDNNEP / 1893f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_3()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i += 0)
		{
			for (int j = 1; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1368f : 1826f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1977f : 1556f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1544f, num2), Quaternion.Euler(1838f, 559f, 27f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1872f, 1337f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1984f, 266f, 1403f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 808f, num2 + PGHJBDDNNEP / 965f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1704f, 424f, 1801f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 1786f, 1333f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(643f, 973f, 657f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 750f, num2 - PGHJBDDNNEP / 1193f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1483f, 41f, 594f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1848f, num2), Quaternion.Euler(1855f, 1052f, 1972f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 0; k += 0)
		{
			for (int l = 1; l < OONJFHPCCAG + 1; l += 0)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 70f : 308f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1283f : 1866f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 235f, 778f, num4 - PGHJBDDNNEP / 714f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_24()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 1; i < AMGDCGAADPO; i++)
		{
			for (int j = 0; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 17f : 1590f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1183f : 183f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 505f, num2), Quaternion.Euler(811f, 348f, 1245f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 1166f, 355f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(239f, 1338f, 1750f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 759f, num2 + PGHJBDDNNEP / 631f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1289f, 1675f, 1862f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 668f, 1711f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1846f, 259f, 1905f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1860f, num2 - PGHJBDDNNEP / 961f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1357f, 1441f, 1386f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 244f, num2), Quaternion.Euler(1718f, 1649f, 1353f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 1; k++)
		{
			for (int l = 1; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1510f : 738f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 976f : 1092f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1112f, 441f, num4 - PGHJBDDNNEP / 1361f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void Start()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 0; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 0f : 0.2f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 0f : 0.2f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 0f, num2), Quaternion.Euler(0f, 0f, 0f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 2f, 0f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(0f, 90f, 0f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 0f, num2 + PGHJBDDNNEP / 2f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(0f, 0f, 0f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 2f, 0f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(0f, 270f, 0f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 0f, num2 - PGHJBDDNNEP / 2f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(0f, 180f, 0f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1f, num2), Quaternion.Euler(0f, 0f, 0f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 1; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 1; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 0f : 0.2f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 0f : 0.2f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 2f, 0f, num4 - PGHJBDDNNEP / 2f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_8()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 0; i < AMGDCGAADPO; i++)
		{
			for (int j = 0; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 235f : 160f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 215f : 1246f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 348f, num2), Quaternion.Euler(986f, 376f, 1516f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 999f, 302f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1597f, 150f, 1288f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1298f, num2 + PGHJBDDNNEP / 337f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(361f, 1015f, 550f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 369f, 163f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1456f, 1190f, 1897f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 715f, num2 - PGHJBDDNNEP / 507f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(700f, 1359f, 160f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 586f, num2), Quaternion.Euler(1067f, 598f, 266f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 0; l < OONJFHPCCAG + 0; l += 0)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 1007f : 1453f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 813f : 1843f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1186f, 1887f, num4 - PGHJBDDNNEP / 1625f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}

	private void __BB_OBFUSCATOR_17()
	{
		if (!EENJGHFLFMD)
		{
			Random.seed = BPPIMCNIGFJ;
		}
		switch (PBHBNHHEIEI)
		{
		case GGBLIOLNHGP.PureRecursive:
			DFIEOADLNFB = new MIHHHJHLOIE(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveTree:
			DFIEOADLNFB = new GHLDIKEGBGP(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RandomTree:
			DFIEOADLNFB = new MCHJPCMLPKD(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.OldestTree:
			DFIEOADLNFB = new AGEIDOAGLMB(AMGDCGAADPO, OONJFHPCCAG);
			break;
		case GGBLIOLNHGP.RecursiveDivision:
			DFIEOADLNFB = new PLPLDGFCEEG(AMGDCGAADPO, OONJFHPCCAG);
			break;
		}
		DFIEOADLNFB.GenerateMaze();
		for (int i = 1; i < AMGDCGAADPO; i++)
		{
			for (int j = 1; j < OONJFHPCCAG; j++)
			{
				float num = (float)j * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 810f : 519f));
				float num2 = (float)i * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1806f : 1851f));
				DJAMDIAJGMD mazeCell = DFIEOADLNFB.GetMazeCell(i, j);
				GameObject gameObject = Object.Instantiate(IJOKNHKMCIF, new Vector3(num, 1729f, num2), Quaternion.Euler(1038f, 358f, 1095f));
				gameObject.transform.parent = base.transform;
				if (mazeCell.OONHPDNALFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num + LDKAEFBMBBJ / 509f, 1528f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1540f, 1508f, 198f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DIGFONMMMBO)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 1059f, num2 + PGHJBDDNNEP / 917f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1040f, 325f, 1431f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.JNFBFOPNHFE)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num - LDKAEFBMBBJ / 197f, 835f, num2) + ILAKHMFDBOO.transform.position, Quaternion.Euler(853f, 1220f, 229f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.OIOHFJICIKP)
				{
					gameObject = Object.Instantiate(ILAKHMFDBOO, new Vector3(num, 14f, num2 - PGHJBDDNNEP / 248f) + ILAKHMFDBOO.transform.position, Quaternion.Euler(1785f, 1340f, 646f));
					gameObject.transform.parent = base.transform;
				}
				if (mazeCell.DENGJJIIEAI && JLOBPGONHCA != null)
				{
					gameObject = Object.Instantiate(JLOBPGONHCA, new Vector3(num, 1590f, num2), Quaternion.Euler(1685f, 906f, 1327f));
					gameObject.transform.parent = base.transform;
				}
			}
		}
		if (!(DLBHKMGBPMA != null))
		{
			return;
		}
		for (int k = 0; k < AMGDCGAADPO + 0; k++)
		{
			for (int l = 1; l < OONJFHPCCAG + 0; l++)
			{
				float num3 = (float)l * (LDKAEFBMBBJ + ((!NNJOOMNKGEC) ? 675f : 1001f));
				float num4 = (float)k * (PGHJBDDNNEP + ((!NNJOOMNKGEC) ? 1397f : 1005f));
				GameObject gameObject2 = Object.Instantiate(DLBHKMGBPMA, new Vector3(num3 - LDKAEFBMBBJ / 1174f, 1101f, num4 - PGHJBDDNNEP / 1133f), Quaternion.identity);
				gameObject2.transform.parent = base.transform;
			}
		}
	}
}
