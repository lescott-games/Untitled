using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grief : MonoBehaviour {

	public float mass = 3f;
	public float entropy = 0f;
	public float breakingPoint = 10f;
	public GameManager gm;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (mass, mass, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale -= new Vector3(0.001F, 0.001F, 0);
		entropy += 0.01f;

		if (transform.localScale.x <= 0) {
			// Game won.
		}

		if (entropy >= breakingPoint) {
			gm.GameOver ();
		}
	}

	public void Decrease() {
		transform.localScale -= new Vector3(0.001F, 0.001F, 0);
	}

	public void Increase() {
		transform.localScale += new Vector3(0.002F, 0.002F, 0);
	}
}
