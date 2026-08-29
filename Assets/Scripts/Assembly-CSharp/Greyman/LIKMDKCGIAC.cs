using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Greyman
{
	public class LIKMDKCGIAC : GNCJMMFLIJB
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
							NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
							NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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

		private void __BB_OBFUSCATOR_15()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1170f), Convert.ToByte(JIAODHDEOPF.g * 905f), Convert.ToByte(JIAODHDEOPF.b * 34f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)4)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(AIOHMEOKILK, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1109f), Convert.ToByte(JIAODHDEOPF.g * 1397f), Convert.ToByte(JIAODHDEOPF.b * 1782f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_22(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1422f), Convert.ToByte(JIAODHDEOPF.g * 917f), Convert.ToByte(JIAODHDEOPF.b * 323f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_4(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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
			BOFECIHGAMD = false;
		}

		private void __BB_OBFUSCATOR_16()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = AIOHMEOKILK;
			}
		}

		private void __BB_OBFUSCATOR_18()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 217f), Convert.ToByte(JIAODHDEOPF.g * 1993f), Convert.ToByte(JIAODHDEOPF.b * 1446f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Fading)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_12()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_1(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_27(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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
			BOFECIHGAMD = false;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_6(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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

		private void FadingDownValues()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 255f), Convert.ToByte(JIAODHDEOPF.g * 255f), Convert.ToByte(JIAODHDEOPF.b * 255f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(AIOHMEOKILK, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_23()
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
				__BB_OBFUSCATOR_9();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 557f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(true);
					MHFKMPGFPFE = false;
					AOLFANACDGD = true;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
					__BB_OBFUSCATOR_19();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				EndFadingValues();
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
		}

		public virtual void __BB_OBFUSCATOR_28()
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
				__BB_OBFUSCATOR_26();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 422f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
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
					NHDFCONNLEL.SetActive(false);
					__BB_OBFUSCATOR_2();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				__BB_OBFUSCATOR_16();
				MHFKMPGFPFE = true;
				AOLFANACDGD = false;
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_5()
		{
			return BJGHPKIJMOJ;
		}

		private void FadingUpValues()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 255f), Convert.ToByte(JIAODHDEOPF.g * 255f), Convert.ToByte(JIAODHDEOPF.b * 255f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_26()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 1434f), Convert.ToByte(JIAODHDEOPF.g * 1717f), Convert.ToByte(JIAODHDEOPF.b * 1007f), 0), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(AIOHMEOKILK, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_13()
		{
			return BJGHPKIJMOJ;
		}

		private void __BB_OBFUSCATOR_2()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 960f), Convert.ToByte(JIAODHDEOPF.g * 1140f), Convert.ToByte(JIAODHDEOPF.b * 1760f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)5)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		[SpecialName]
		public virtual bool __BB_OBFUSCATOR_24()
		{
			return BJGHPKIJMOJ;
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_21(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.SetActive(false);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1607f), Convert.ToByte(JIAODHDEOPF.g * 67f), Convert.ToByte(JIAODHDEOPF.b * 340f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)7)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		private void __BB_OBFUSCATOR_19()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1862f), Convert.ToByte(JIAODHDEOPF.g * 504f), Convert.ToByte(JIAODHDEOPF.b * 139f), 1), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}

		public virtual void __BB_OBFUSCATOR_3()
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
				__BB_OBFUSCATOR_15();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 970f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = false;
				}
				if ((ECPOCCNBINF && !GMADBCDMFKM.showOnScreen) || (!ECPOCCNBINF && !GMADBCDMFKM.showOffScreen))
				{
					NHDFCONNLEL.SetActive(true);
					MHFKMPGFPFE = true;
					AOLFANACDGD = true;
				}
				else
				{
					NHDFCONNLEL.SetActive(false);
					__BB_OBFUSCATOR_0();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				__BB_OBFUSCATOR_8();
				MHFKMPGFPFE = true;
				AOLFANACDGD = true;
			}
		}

		private void __BB_OBFUSCATOR_7()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = AIOHMEOKILK;
			}
		}

		[SpecialName]
		public virtual void __BB_OBFUSCATOR_14(bool LNDAKDHHOCJ)
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
						NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.onScreenSprite;
						NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.onScreenColor;
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
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = GMADBCDMFKM.offScreenSprite;
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = GMADBCDMFKM.offScreenColor;
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

		private void __BB_OBFUSCATOR_8()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)5)
			{
				NHDFCONNLEL.transform.localScale = AIOHMEOKILK;
			}
		}

		private void __BB_OBFUSCATOR_9()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(JIAODHDEOPF, new Color32(Convert.ToByte(JIAODHDEOPF.r * 787f), Convert.ToByte(JIAODHDEOPF.g * 1148f), Convert.ToByte(JIAODHDEOPF.b * 962f), 1), COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == (Indicator.HEAIKMFPCIA)6)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(AIOHMEOKILK, Vector3.zero, COGBKJMIKCI / GMADBCDMFKM.transitionDuration);
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
				FadingDownValues();
			}
			else if (COGBKJMIKCI < GMADBCDMFKM.transitionDuration * 2f)
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
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
					FadingUpValues();
				}
			}
			else
			{
				if (!BOFECIHGAMD)
				{
					NHDFCONNLEL.GetComponent<SpriteRenderer>().sprite = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenSprite : GMADBCDMFKM.offScreenSprite);
					NHDFCONNLEL.GetComponent<SpriteRenderer>().color = ((!AOLFANACDGD) ? GMADBCDMFKM.onScreenColor : GMADBCDMFKM.offScreenColor);
					BJGHPKIJMOJ = HGOGPEIIBJF;
					BOFECIHGAMD = true;
				}
				EndFadingValues();
				MHFKMPGFPFE = false;
				AOLFANACDGD = false;
			}
		}

		private void EndFadingValues()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = JIAODHDEOPF;
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.Scaling)
			{
				NHDFCONNLEL.transform.localScale = AIOHMEOKILK;
			}
		}

		private void __BB_OBFUSCATOR_17()
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
				NHDFCONNLEL.GetComponent<SpriteRenderer>().color = Color32.Lerp(new Color32(Convert.ToByte(JIAODHDEOPF.r * 1621f), Convert.ToByte(JIAODHDEOPF.g * 1742f), Convert.ToByte(JIAODHDEOPF.b * 1520f), 0), JIAODHDEOPF, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
			if (GMADBCDMFKM.transition == Indicator.HEAIKMFPCIA.None)
			{
				NHDFCONNLEL.transform.localScale = Vector3.Lerp(Vector3.zero, AIOHMEOKILK, (COGBKJMIKCI - GMADBCDMFKM.transitionDuration) / GMADBCDMFKM.transitionDuration);
			}
		}
	}
}
