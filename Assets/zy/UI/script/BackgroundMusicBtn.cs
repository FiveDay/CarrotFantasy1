﻿using UnityEngine;
using System.Collections;

public class BackgroundMusicBtn : MonoBehaviour {

	protected bool switchFlag = true; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick(){
		if (this.switchFlag) {  
			this.GetComponent<UISprite> ().spriteName = "setting02-music-1";  
			this.GetComponent<UIButton> ().normalSprite = "setting02-music-1";  
			this.switchFlag = false;  
		}  
		else{  
			this.GetComponent<UISprite>().spriteName = "setting02-music-2";  
			this.GetComponent<UIButton>().normalSprite = "setting02-music-2";  
			this.switchFlag = true;  
		}
	}
}