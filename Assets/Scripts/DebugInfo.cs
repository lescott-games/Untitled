﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour {

	public Button debugButton;
	public Background background;
	public Slider debugSlider;

	private bool debugToggle = false;
	private Button btn;
	private Background bg;
	private Text text;
	private Text txt;
	private GameManager gameManager;
	private Spawn spawn;

	// Use this for initialization
	void Start () {
		btn = debugButton.GetComponent<Button> ();
		bg = background.GetComponent<Background> ();
		txt = gameObject.GetComponent<Text> ();
		btn.onClick.AddListener (ToggleInfo);
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager> ();
		spawn = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Spawn> ();
		debugSlider.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (debugToggle == true &&  (Input.touchCount > 1 || Input.GetMouseButton(0) == true 
			|| Input.GetMouseButton(1) == true)) {
			txt.text = "Game duration: " + gameManager.gameDurationSeconds + " seconds" +
				"\nTouch time: " + bg.timeHeldDown + " seconds" +
				"\nPercent of game finished: " + bg.gameShift + "%" +
				"\nGame time: " + gameManager.niceTimer +
				"\nContinuous touch time: " + bg.touchTime + 
				"\nGame phase: " + spawn.phase;
			//print ("Should be updating debug.");
		}
	}

	void ToggleInfo(){
		if (debugToggle == false) {
			txt.text = "Game duration: " + gameManager.gameDurationSeconds + " seconds" +
				"\nTouch time: " + bg.timeHeldDown + " seconds" +
				"\nPercent of game finished: " + bg.gameShift + "%" +
				"\nGame time: " + gameManager.niceTimer +
				"\nContinuous touch time: " + bg.touchTime + 
				"\nGame phase: " + spawn.phase;
			debugToggle = true;
			debugSlider.gameObject.SetActive (true);
		} else {
			txt.text = "";
			debugToggle = false;
			debugSlider.gameObject.SetActive (false);
		}
	}
}
