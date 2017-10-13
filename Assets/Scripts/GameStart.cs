using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	public Text continueText;
	public float textBlinkRate;

	private bool titleSwitch = true;
	private float textBlink;


	// Use this for initialization
	void Start () {
		textBlink = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (titleSwitch == true) {
			textBlink -= textBlinkRate;
		} else if (titleSwitch == false) {
			textBlink += textBlinkRate;
		}
		if (textBlink <= 0) {
			titleSwitch = false;
		} else if (textBlink >= 1) {
			titleSwitch = true;
		}
		continueText.color = Color.Lerp (Color.black, Color.white, textBlink);

		if (Input.anyKeyDown)
			SceneManager.LoadScene ("Main");
			
	}
}
