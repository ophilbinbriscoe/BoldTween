﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace ToBoldlyPlay.Tweening
{
	public class AnchoredPositionInterpolator : Interpolator<Vector2>, IRect
	{
		[SerializeField]
		private RectTransform rect;
		
		public RectTransform Rect
		{
			get
			{
				return rect;
			}

			set
			{
				rect = value;
			}
		}

		public override void Interpolate ( float t )
		{
			if ( rect != null )
			{
				rect.anchoredPosition = Vector2.Lerp( a, b, t );
			}
		}
	}
}
