﻿using UnityEngine;

namespace AF
{
	public class BlackBarsSafeScreen : MonoBehaviour
	{
		private Rect lastSafeArea = Rect.zero;

		public RectTransform LeftRectTransform { get; private set; }
		public RectTransform RightRectTransform { get; private set; }

		public void Awake()
		{
			LeftRectTransform = transform.Find("LeftBlackBar").GetComponent<RectTransform>();
			RightRectTransform = transform.Find("RightBlackBar").GetComponent<RectTransform>();
			LeftRectTransform.gameObject.SetActive(true);
			RightRectTransform.gameObject.SetActive(true);
			Refresh();
		}

		public void Update()
		{
			Refresh();
		}

		private void Refresh()
		{
			var safeArea = Screen.safeArea;

			if (safeArea != lastSafeArea)
			{
				ApplyBlackBar(safeArea);
			}
		}

		/// <summary>
		/// Set position and size for Black Bars
		/// </summary>
		/// <param name="safeArea">Safea area of the screen</param>
		private void ApplyBlackBar(Rect safeArea)
		{
			var maxAnchorX = safeArea.xMin / Screen.width;
			LeftRectTransform.anchorMax = new Vector2(maxAnchorX, LeftRectTransform.anchorMax.y);

			var minAnchorX = safeArea.xMax / Screen.width;
			RightRectTransform.anchorMin = new Vector2(minAnchorX, LeftRectTransform.anchorMin.y);
		}
	}
}