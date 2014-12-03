﻿using UnityEngine;
using System.Collections;

public class CompleteStage : MonoBehaviour {
	public string stageName;
	public UIButton thisButton;
	public GameObject congratsAnimation;
	public AudioClip audioClip;

	void OnClick(){
	foreach (Level l in GameData.current.levels){
			if (l.name.Equals(stageName)){
				l.Complete();
				thisButton.enabled = false;
				NGUITools.SetActive(thisButton.gameObject, false);
				congratsAnimation.renderer.enabled = true;
				NGUITools.PlaySound(audioClip, GlobalVars.soundVolume, 1f);
			}
		}
	}

	// Use this for initialization
	void Start () {
		foreach (Level l in GameData.current.levels){
			if (l.isComplete){
				Debug.Log("it's complete");
				thisButton.isEnabled = false;
				NGUITools.SetActive(thisButton.gameObject, false);
				congratsAnimation.renderer.enabled = true;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}