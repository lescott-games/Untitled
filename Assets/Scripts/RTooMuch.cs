using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTooMuch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount == 0 && Input.GetMouseButton (0) == false
		    && Input.GetMouseButton (1) == false)) {
			Destroy (gameObject, 0.5f);
		}
	}
}
