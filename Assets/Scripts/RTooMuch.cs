using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTooMuch : MonoBehaviour {

	public float min = -5.0f;
	public float max = 5.0f;
	public float rate = 0.1f;

	private float t = 0.0f;

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

		transform.localScale = new Vector3 (Mathf.Lerp (min, max, t), Mathf.Lerp (min, max, t));

		t += rate * Time.deltaTime;

		if (t > 1.0f) {
			float temp = max;
			max = min;
			min = temp;
			t = 0.0f;
		}
		 
	}
}
