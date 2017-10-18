using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGratitude : MonoBehaviour {

	public float fadeRate;

	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer> ();
		Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		Color color = sr.color;
		color.a -= fadeRate;
		sr.color = color;
	}
}
