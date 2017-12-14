using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugSliderScript : MonoBehaviour {

	public Background background;
	public Image debugSliderFill;

	private Slider slider;

	// Use this for initialization
	void Start () {
		slider = gameObject.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = background.gameShift;
		if (GameObject.Find("RRevert2(Clone)"))
		{
			debugSliderFill.color = new Color(128, 0, 128);
		} else {
			debugSliderFill.color = Color.yellow;
		}
	}
}
