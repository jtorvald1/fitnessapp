﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BestFitWithoutCutting : MonoBehaviour {
	
	public Text text;
	
	void Start () {
		StartCoroutine (FixHeight (1f));
	}
	
	IEnumerator FixHeight(float sec)
	{
		yield return new WaitForSeconds(sec);
		TextGenerator gen = text.cachedTextGenerator;
		Rect rect = text.rectTransform.rect;
		while (true)
		{
			while (rect.height >= 2 * gen.fontSizeUsedForBestFit)
			{
				text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, gen.fontSizeUsedForBestFit);
				yield return null;
				rect = text.rectTransform.rect;
			}
			yield return null;
		}
	}
}