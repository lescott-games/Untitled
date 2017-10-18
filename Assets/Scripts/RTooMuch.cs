using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTooMuch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}
/*
	void OnMouseDown() {
		CancelInvoke ("DestroyMe");
	}

	void OnMouseUp() {
		Invoke ("DestroyMe", 3.0f);
	}

	void DestroyMe() {
		Destroy (gameObject, 3.0f);
	}
*/
}
