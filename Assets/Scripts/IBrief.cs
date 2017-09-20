using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IBrief : MonoBehaviour {

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
		Destroy (gameObject, 2.0f);
	}

	void OnMouseDrag () {
		bgScript.ShiftUp ();
	}

	void OnMouseDown() {
		sr.color = Color.gray;
	}

	void OnMouseUp(){
		sr.color = Color.white;
		//
	}
}
