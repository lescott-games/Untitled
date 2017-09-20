using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILong : MonoBehaviour {

	private GameObject background;
	private Background bgScript;
	private SpriteRenderer sr;

	public int colorChange = 20;

	// Use this for initialization
	void Start () {
		background = GameObject.FindGameObjectWithTag ("Background");
		bgScript = background.GetComponent<Background> ();
		sr = gameObject.GetComponent<SpriteRenderer> ();
		print ("Initial color: " + sr.color);
		Destroy (gameObject, 5.0f);
	}

	void OnMouseDrag () {
		bgScript.ShiftUp ();
		// change color on tap for player feedback
	}

	void OnMouseDown() {
/*		Color c = sr.color;
		c.r = c.r + colorChange;
		c.g = c.g + colorChange;
		c.b = c.b + colorChange;
		sr.color = c;
		print ("Color: " + c);
		*/
		sr.color = Color.blue;
	}

	void OnMouseUp(){
/*		Color c = sr.color;
		c.r = c.r - colorChange;
		c.g = c.g - colorChange;
		c.b = c.b - colorChange;
		sr.color = c;
		print ("Color: " + c);
		*/
		sr.color = Color.green;
	}
}
