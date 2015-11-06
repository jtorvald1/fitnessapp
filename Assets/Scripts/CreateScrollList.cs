﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item {
	public string name;
	public Sprite icon;
	public Button.ButtonClickedEvent thingToDo;
}

public class CreateScrollList : MonoBehaviour {
	
	public GameObject sampleButton;
	public List<Item> itemList;
	
	public Transform contentPanel;
	
	void Start () {
		PopulateList ();
	}
	
	void PopulateList () {
		foreach (var item in itemList) {
			GameObject newButton = Instantiate (sampleButton) as GameObject;
			SampleButton button = newButton.GetComponent <SampleButton> ();
			button.nameLabel.text = item.name;
			button.icon.sprite = item.icon;
			//          button.button.onClick = item.thingToDo;
			newButton.transform.SetParent (contentPanel);
		}
	}
	
	public void SomethingToDo () {
		Debug.Log ("I done did something!");
	}
	
	public void SomethingElseToDo (GameObject item) {
		Debug.Log (item.name);
	}
}