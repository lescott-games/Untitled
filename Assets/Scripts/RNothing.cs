using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNothing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Nothing Response spawned.");
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 2.0f);
	}
}
