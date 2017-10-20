using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITrail : MonoBehaviour {

	private SpriteRenderer sr;
	private Color initialColor;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer> ();
		initialColor = sr.color;
		Destroy (gameObject, 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		sr.color = Color.green;
	}

	void OnMouseUp(){
		sr.color = initialColor;
	}
}
