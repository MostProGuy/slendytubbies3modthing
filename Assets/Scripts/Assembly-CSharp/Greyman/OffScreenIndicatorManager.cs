using System.Collections.Generic;
using UnityEngine;

namespace Greyman
{
	public abstract class OffScreenIndicatorManager : MonoBehaviour
	{
		public bool AEALEOFKOPN;

		protected List<GNCJMMFLIJB> KDGECPNEIPI;

		public Indicator[] IDIPDBFKMJJ;

		public abstract void AddIndicator(Transform LJLBGNFIOPI, int ECAECMDNCLM);

		public abstract void RemoveIndicator(Transform LJLBGNFIOPI);

		protected abstract void UpdateIndicatorPosition(GNCJMMFLIJB LLKFDMIPHDF, int CLDLINNFAGA = 0);

		private void Awake()
		{
			KDGECPNEIPI = new List<GNCJMMFLIJB>();
		}

		protected bool ExistsIndicator(Transform LJLBGNFIOPI)
		{
			bool result = false;
			foreach (GNCJMMFLIJB item in KDGECPNEIPI)
			{
				if (item.LJLBGNFIOPI == LJLBGNFIOPI)
				{
					result = true;
				}
			}
			return result;
		}

		public void CheckFields()
		{
			Indicator[] iDIPDBFKMJJ = IDIPDBFKMJJ;
			foreach (Indicator indicator in iDIPDBFKMJJ)
			{
				if (indicator.onScreenSprite == null)
				{
					indicator.showOnScreen = false;
				}
				else
				{
					indicator.showOnScreen = true;
				}
				if (indicator.offScreenSprite == null)
				{
					indicator.showOffScreen = false;
				}
				else
				{
					indicator.showOffScreen = true;
				}
				if (!indicator.showOnScreen && !indicator.showOffScreen)
				{
					Debug.LogError("You should add at least one Sprite for offScreen or onScreen. Otherwise this Indicator is useless.");
					Debug.Break();
				}
			}
		}
	}
}
