using System;
using UnityEngine;

namespace Greyman
{
	[Serializable]
	public class Indicator
	{
		public enum HEAIKMFPCIA
		{
			None = 0,
			Fading = 1,
			Scaling = 2
		}

		public Sprite onScreenSprite;

		public Color onScreenColor = Color.white;

		public bool onScreenRotates;

		public Sprite offScreenSprite;

		public Color offScreenColor = Color.white;

		public bool offScreenRotates;

		public Vector3 targetOffset;

		public HEAIKMFPCIA transition;

		public float transitionDuration = 1f;

		[NonSerialized]
		public bool showOnScreen;

		[NonSerialized]
		public bool showOffScreen;
	}
}
