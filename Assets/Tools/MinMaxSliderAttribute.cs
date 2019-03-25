#if UNITY_EDITOR || UNITY_EDITOR_64 || UNITY_EDITOR_WIN
using System;
using UnityEngine;

public class MinMaxSliderAttribute : PropertyAttribute {

	public readonly float max;
	public readonly float min;

	public MinMaxSliderAttribute (float min, float max) {
		this.min = min;
		this.max = max;
	}
}
#endif