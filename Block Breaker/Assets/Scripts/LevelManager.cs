﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: "+name);
		Application.LoadLevel(name);
		Brick.breakableCount = 0;
	}
	public void QuitRequest(){
		Debug.Log ("Quit Game requested");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void BrickDestroyed(){
		if(Brick.breakableCount <= 0)
			LoadNextLevel();
	}
}
