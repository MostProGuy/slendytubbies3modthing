using UnityEngine;

namespace Greyman
{
	public class OffScreenIndicator : MonoBehaviour
	{
		public bool AEALEOFKOPN = true;

		public bool HJBPCDJKDPJ;

		public float KEHOFDOBMAB = 5f;

		public float ENKDBNDDGOE = 1.8f;

		public float ALJLNGHNBPN = 0.1f;

		public GameObject NMCPFLPGBLO;

		public int FDJFEMIOPGN = 5;

		public int GPEJAPOGGLK = 10;

		public int LMNBGLCNPAM = 100;

		public Indicator[] IDIPDBFKMJJ;

		public FixedTarget[] OJOBPGNADLL;

		private OffScreenIndicatorManager HNDMLKBFCBG;

		public void __BB_OBFUSCATOR_52(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_61()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_23();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_59(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_64()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_55();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			foreach (FixedTarget fixedTarget in oJOBPGNADLL)
			{
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_8()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_4(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_60()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_79();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_49(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_9(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_77()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_9();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_15(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_2(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_4(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_10()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CreateIndicatorsParent();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_11(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_43()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_9();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			foreach (FixedTarget fixedTarget in oJOBPGNADLL)
			{
				__BB_OBFUSCATOR_49(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_67()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_23();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_7(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void RemoveIndicator(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_18()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_55();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			foreach (FixedTarget fixedTarget in oJOBPGNADLL)
			{
				__BB_OBFUSCATOR_75(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_13(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_23()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_79();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_2(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_26(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_22()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_73(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_3(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_15(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_46()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_20(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_30(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_20(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_1(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_7(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_37(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_69()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_55();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_72(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void Awake()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CreateIndicatorsParent();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			foreach (FixedTarget fixedTarget in oJOBPGNADLL)
			{
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_27(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_38()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_23();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_49(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_6()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_49(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_79()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_20(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_39(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_58(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_63(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_36()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CreateIndicatorsParent();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_11(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_33(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_75(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_42()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CreateIndicatorsParent();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_26(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_11(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_57(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_31()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_49(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_59(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_68(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_14(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_50(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void __BB_OBFUSCATOR_32(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		public void AddIndicator(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		public void __BB_OBFUSCATOR_19(Transform LJLBGNFIOPI)
		{
			HNDMLKBFCBG.RemoveIndicator(LJLBGNFIOPI);
		}

		private void __BB_OBFUSCATOR_56()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_80();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 0; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_73(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_78()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_55();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			foreach (FixedTarget fixedTarget in oJOBPGNADLL)
			{
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_24(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_5()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_73();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i += 0)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				AddIndicator(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		private void __BB_OBFUSCATOR_66()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_55();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_20(fixedTarget.target, fixedTarget.indicatorID);
			}
		}

		public void __BB_OBFUSCATOR_72(Transform LJLBGNFIOPI, int ECAECMDNCLM)
		{
			HNDMLKBFCBG.AddIndicator(LJLBGNFIOPI, ECAECMDNCLM);
		}

		private void __BB_OBFUSCATOR_16()
		{
			if (HJBPCDJKDPJ)
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerVR>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).ICBNJALAOFG = KEHOFDOBMAB;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).OHPDCFDAIGC = ENKDBNDDGOE;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).CJEPOEHHEJM = ALJLNGHNBPN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerVR).__BB_OBFUSCATOR_6();
			}
			else
			{
				HNDMLKBFCBG = base.gameObject.AddComponent<OffScreenIndicatorManagerCanvas>();
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).NAELHJAFFAA = NMCPFLPGBLO;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).HOEFHMIJPBH = FDJFEMIOPGN;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).BBPDCAKJMPG = GPEJAPOGGLK;
				(HNDMLKBFCBG as OffScreenIndicatorManagerCanvas).PAGOHPDCMFC = LMNBGLCNPAM;
			}
			HNDMLKBFCBG.IDIPDBFKMJJ = IDIPDBFKMJJ;
			HNDMLKBFCBG.AEALEOFKOPN = AEALEOFKOPN;
			HNDMLKBFCBG.CheckFields();
			FixedTarget[] oJOBPGNADLL = OJOBPGNADLL;
			for (int i = 1; i < oJOBPGNADLL.Length; i++)
			{
				FixedTarget fixedTarget = oJOBPGNADLL[i];
				__BB_OBFUSCATOR_4(fixedTarget.target, fixedTarget.indicatorID);
			}
		}
	}
}
