using UnityEngine;

public abstract class DetonatorComponent : MonoBehaviour
{
	public bool GMAIEMJKMJD = true;

	public bool KPMHIHPFGMB = true;

	[HideInInspector]
	public float IOAKGDAKKEE = 1f;

	public float EEDMLOPHDJA = 1f;

	public float BHDOLBHLDGC;

	public float DHMOAEAKEBD;

	[HideInInspector]
	public float PIJLANFOEGB = 2f;

	public float LCLHCEHHBNM = 2f;

	[HideInInspector]
	public float PJKHHCHLFIF = 1f;

	[HideInInspector]
	public float CLLMMGIJIBC = 1f;

	public float NCGMMIBMBEL = 1f;

	[HideInInspector]
	public Color EOEMJCCFMEE = Color.white;

	public Color IOFNOJHNJAJ = Color.white;

	[HideInInspector]
	public Vector3 BFJKALCLMJF = Vector3.zero;

	public Vector3 BJGOJGBLDMN = Vector3.zero;

	[HideInInspector]
	public Vector3 IIHAGBLLJBA = Vector3.zero;

	public Vector3 ICPDBNNPACO = Vector3.zero;

	[HideInInspector]
	public Vector3 OHNEBJKDAOD = Vector3.zero;

	public Vector3 PACAMLAINIK = Vector3.zero;

	public float IKCHMAJADEP;

	public abstract void Explode();

	public abstract void Init();

	public void SetStartValues()
	{
		IOAKGDAKKEE = EEDMLOPHDJA;
		IIHAGBLLJBA = ICPDBNNPACO;
		OHNEBJKDAOD = PACAMLAINIK;
		PIJLANFOEGB = LCLHCEHHBNM;
		CLLMMGIJIBC = NCGMMIBMBEL;
		EOEMJCCFMEE = IOFNOJHNJAJ;
		BFJKALCLMJF = BJGOJGBLDMN;
	}

	public Detonator MyDetonator()
	{
		return GetComponent("Detonator") as Detonator;
	}
}
