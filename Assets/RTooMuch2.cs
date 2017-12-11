using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTooMuch2 : MonoBehaviour {


	private float t = 0.0f;
	private Background bg;

	// Use this for initialization
	void Start () {
		bg = GameObject.FindWithTag("Background").GetComponent<Background>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount == 0 && Input.GetMouseButton (0) == false
			&& Input.GetMouseButton (1) == false)) {
			Destroy (gameObject, 0.5f);
		}

		if ((Input.touchCount > 1 || Input.GetMouseButton (0) == true
			|| Input.GetMouseButton (1) == true)) {
			bg.StopShift ();
		}
	}
}
