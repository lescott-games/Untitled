using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RRevert : MonoBehaviour {

	private GameObject background;
	private Background bgScript;

	// Use this for initialization
	void Start () {
		background = GameObject.FindGameObjectWithTag ("Background");
		bgScript = background.GetComponent<Background> ();
		Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		bgScript.ReverseShift ();
	}
}
