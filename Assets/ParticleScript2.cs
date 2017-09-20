using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript2 : MonoBehaviour {

	public GameObject[] particles;
	public Camera mainCamera;
	//public float gameDurationSeconds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact")) {
			Vector3 screenPoint = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			GameObject particleObject = particles[Random.Range(0, particles.Length)];
			Instantiate (particleObject, screenPoint, Quaternion.identity);
		}
	}
}
