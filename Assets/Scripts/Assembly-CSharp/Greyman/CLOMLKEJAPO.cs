using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Greyman
{
	public class CLOMLKEJAPO : GNCJMMFLIJB
	{
		public override bool ECPOCCNBINF
		{
			get
			{
				return BJGHPKIJMOJ;
			}
			set
			{
				if (HGOGPEIIBJF == value)
				{
					return;
				}
				HGOGPEIIBJF = value;
				if (value)
				{
					if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
					{
						BJGHPKIJMOJ = value;
						if (GMADBCDMFKM.showOnScreen)
						{
							NHDFCONNLEL.SetActive(true);
							NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
							NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
						}
						else
						{
							NHDFCONNLEL.SetActive(false);
						}
					}
					else
					{
						MHFKMPGFPFE = true;
						AOLFANACDGD = false;
					}
				}
				else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = value;
					if (GMADBCDMFKM.showOffScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
				DJPBFEJDAGM = Time.time;
				BOFECIHGAMD = false;
			}
		}

		public virtual void __BB_OBFUSCATOR_64()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_117();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 296f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_11();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				__BB_OBFUSCATOR_92();
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_38()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_56()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_71()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1969f), Convert.ToByte(JIAODHDEOPF.g * 1830f), Convert.ToByte(JIAODHDEOPF.b * 779f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_113()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 797f), Convert.ToByte(JIAODHDEOPF.g * 1880f), Convert.ToByte(JIAODHDEOPF.b * 140f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_41()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1452f), Convert.ToByte(JIAODHDEOPF.g * 669f), Convert.ToByte(JIAODHDEOPF.b * 291f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_83(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_103()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_76()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 696f), Convert.ToByte(JIAODHDEOPF.g * 46f), Convert.ToByte(JIAODHDEOPF.b * 1621f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)5)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_61()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_81()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1406f), Convert.ToByte(JIAODHDEOPF.g * 783f), Convert.ToByte(JIAODHDEOPF.b * 675f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_46()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_109()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1388f), Convert.ToByte(JIAODHDEOPF.g * 1390f), Convert.ToByte(JIAODHDEOPF.b * 281f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)5)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void endFadingValues()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_89(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(false);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_4()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1159f), Convert.ToByte(JIAODHDEOPF.g * 544f), Convert.ToByte(JIAODHDEOPF.b * 1949f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_69()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_20(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_98()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1305f), Convert.ToByte(JIAODHDEOPF.g * 1267f), Convert.ToByte(JIAODHDEOPF.b * 20f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_105()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1969f), Convert.ToByte(JIAODHDEOPF.g * 1617f), Convert.ToByte(JIAODHDEOPF.b * 707f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_43()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_104()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1306f), Convert.ToByte(JIAODHDEOPF.g * 1468f), Convert.ToByte(JIAODHDEOPF.b * 1119f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_117()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1221f), Convert.ToByte(JIAODHDEOPF.g * 1571f), Convert.ToByte(JIAODHDEOPF.b * 303f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_70(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_75()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_54(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(false);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_93()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)7)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		public override void UpdateEffects()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				fadingDownValues();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 2f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					fadingUpValues();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				endFadingValues();
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_62(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_39()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1120f), Convert.ToByte(JIAODHDEOPF.g * 92f), Convert.ToByte(JIAODHDEOPF.b * 1645f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_47(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_90()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1512f), Convert.ToByte(JIAODHDEOPF.g * 482f), Convert.ToByte(JIAODHDEOPF.b * 363f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)5)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_114()
		{
			return BJGHPKIJMOJ;
		}

		public virtual void __BB_OBFUSCATOR_29()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_85();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 1014f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_98();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_112();
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
		}

		private void __BB_OBFUSCATOR_115()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_58()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_94(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_7()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		public virtual void __BB_OBFUSCATOR_106()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_101();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 522f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_11();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_5();
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
		}

		private void __BB_OBFUSCATOR_85()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 79f), Convert.ToByte(JIAODHDEOPF.g * 1106f), Convert.ToByte(JIAODHDEOPF.b * 921f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_73()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1734f), Convert.ToByte(JIAODHDEOPF.g * 729f), Convert.ToByte(JIAODHDEOPF.b * 27f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_92()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_36(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_72(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_87()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_0()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1822f), Convert.ToByte(JIAODHDEOPF.g * 1599f), Convert.ToByte(JIAODHDEOPF.b * 519f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_6()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_74(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_30()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1592f), Convert.ToByte(JIAODHDEOPF.g * 1284f), Convert.ToByte(JIAODHDEOPF.b * 294f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_79()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_50()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_99()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_100()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_37()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 16f), Convert.ToByte(JIAODHDEOPF.g * 1186f), Convert.ToByte(JIAODHDEOPF.b * 1529f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_8()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_67(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		public virtual void __BB_OBFUSCATOR_53()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_110();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 47f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_59();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_58();
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
		}

		private void __BB_OBFUSCATOR_22()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 592f), Convert.ToByte(JIAODHDEOPF.g * 508f), Convert.ToByte(JIAODHDEOPF.b * 718f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)7)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_5()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		public virtual void __BB_OBFUSCATOR_40()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_105();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 304f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_11();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				__BB_OBFUSCATOR_75();
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
		}

		private void __BB_OBFUSCATOR_68()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1930f), Convert.ToByte(JIAODHDEOPF.g * 635f), Convert.ToByte(JIAODHDEOPF.b * 45f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)7)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_63()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1666f), Convert.ToByte(JIAODHDEOPF.g * 1131f), Convert.ToByte(JIAODHDEOPF.b * 383f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void fadingDownValues()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 255f), Convert.ToByte(JIAODHDEOPF.g * 255f), Convert.ToByte(JIAODHDEOPF.b * 255f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_112()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_107()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_108()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 61f), Convert.ToByte(JIAODHDEOPF.g * 397f), Convert.ToByte(JIAODHDEOPF.b * 1838f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_23()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_17()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_84()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1831f), Convert.ToByte(JIAODHDEOPF.g * 952f), Convert.ToByte(JIAODHDEOPF.b * 1445f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_110()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 994f), Convert.ToByte(JIAODHDEOPF.g * 143f), Convert.ToByte(JIAODHDEOPF.b * 739f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_97()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_11()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 491f), Convert.ToByte(JIAODHDEOPF.g * 1548f), Convert.ToByte(JIAODHDEOPF.b * 336f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_31(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_59()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 811f), Convert.ToByte(JIAODHDEOPF.g * 183f), Convert.ToByte(JIAODHDEOPF.b * 1668f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_2()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_105();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 283f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(true);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_81();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_50();
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_49(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_48()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_1()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void fadingUpValues()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 255f), Convert.ToByte(JIAODHDEOPF.g * 255f), Convert.ToByte(JIAODHDEOPF.b * 255f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_51()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_102(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(false);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_12()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_91()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 446f), Convert.ToByte(JIAODHDEOPF.g * 513f), Convert.ToByte(JIAODHDEOPF.b * 1705f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_96()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_76();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 393f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(false);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_68();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_107();
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_82()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_3()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_33()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 12f), Convert.ToByte(JIAODHDEOPF.g * 731f), Convert.ToByte(JIAODHDEOPF.b * 891f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_10(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(false);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_57()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)7)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_35()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_101()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1190f), Convert.ToByte(JIAODHDEOPF.g * 793f), Convert.ToByte(JIAODHDEOPF.b * 1069f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_16()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_71();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 381f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(true);
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
					__BB_OBFUSCATOR_37();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_115();
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_86()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_80()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1530f), Convert.ToByte(JIAODHDEOPF.g * 918f), Convert.ToByte(JIAODHDEOPF.b * 4f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_111()
		{
			if (!MHFKMPGFPFE && !AOLFANACDGD)
			{
				return;
			}
			COGBKJMIKCI = Time.time - DJPBFEJDAGM;
			if ((MHFKMPGFPFE && !GMADBCDMFKM.showOffScreen) || (AOLFANACDGD && !GMADBCDMFKM.showOnScreen))
			{
				COGBKJMIKCI += GMADBCDMFKM.transitionDuration;
			}
			if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration)
			{
				__BB_OBFUSCATOR_33();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 1636f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(true);
					MHFKMPGFPFE = true;
					AOLFANACDGD = false;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
					__BB_OBFUSCATOR_32();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<Image>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<Image>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				__BB_OBFUSCATOR_107();
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_24()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_25()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_14()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_116()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_34(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_15(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(false);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(true);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = true;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_28()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1218f), Convert.ToByte(JIAODHDEOPF.g * 1373f), Convert.ToByte(JIAODHDEOPF.b * 112f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)3)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_66()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_95()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1589f), Convert.ToByte(JIAODHDEOPF.g * 1285f), Convert.ToByte(JIAODHDEOPF.b * 1113f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_88()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.one;
			}
		}

		private void __BB_OBFUSCATOR_32()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1435f), Convert.ToByte(JIAODHDEOPF.g * 1505f), Convert.ToByte(JIAODHDEOPF.b * 426f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_26(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(false);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
				}
			}
			else
			{
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = false;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_9(bool LNDAKDHHOCJ)
		{
			if (HGOGPEIIBJF == LNDAKDHHOCJ)
			{
				return;
			}
			HGOGPEIIBJF = LNDAKDHHOCJ;
			if (LNDAKDHHOCJ)
			{
				if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
				{
					BJGHPKIJMOJ = LNDAKDHHOCJ;
					if (GMADBCDMFKM.showOnScreen)
					{
						NHDFCONNLEL.SetActive(true);
						NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.onScreenColor;
					}
					else
					{
						NHDFCONNLEL.SetActive(true);
					}
				}
				else
				{
					MHFKMPGFPFE = false;
					AOLFANACDGD = false;
				}
			}
			else if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				BJGHPKIJMOJ = LNDAKDHHOCJ;
				if (GMADBCDMFKM.showOffScreen)
				{
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<Image>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<Image>().color = GMADBCDMFKM.offScreenColor;
				}
				else
				{
					NHDFCONNLEL.SetActive(true);
				}
			}
			else
			{
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
			DJPBFEJDAGM = Time.time;
			BOFECIHGAMD = true;
		}

		private void __BB_OBFUSCATOR_65()
		{
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				if (ECPOCCNBINF)
				{
					JIAODHDEOPF = GMADBCDMFKM.onScreenColor;
				}
				else
				{
					JIAODHDEOPF = GMADBCDMFKM.offScreenColor;
				}
				NHDFCONNLEL.GetComponent<Image>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1527f), Convert.ToByte(JIAODHDEOPF.g * 1814f), Convert.ToByte(JIAODHDEOPF.b * 619f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)8)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}
	}
}
