﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FacebookFriendManager : MonoBehaviour {

	public List<FacebookFriend> facebookFriendsList = new List<FacebookFriend>();
	
	#region Init
	private static FacebookFriendManager _instance;
	public static FacebookFriendManager Instance
	{
		get
		{
			return _instance;
		}
	}
	
	void Awake() {
		
		//first Singleton is created
		if(_instance == null)
		{
			//If I am the first instance, make me the Singleton
			_instance = this;
			DontDestroyOnLoad(this);
		}
		else
		{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != _instance)
				Destroy(this.gameObject);
		}
	}
	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetFacebookFriendImage (string friendID, Sprite image) {
		FacebookFriend friend = GetFriendByID (friendID);
		friend.FriendProfilePic = image;
	}

	public FacebookFriend GetFriendByID (string friendID) {
		FacebookFriend result = facebookFriendsList.Find(x => x.FriendID == friendID);
		return result;
	}

	public void PrintAllMessages() {
		foreach (FacebookFriend friend in facebookFriendsList) {
			foreach(Message message in friend.FriendUnreadMessages) {
				print(message.message);
			}
		}
	}
}
