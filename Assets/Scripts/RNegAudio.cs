using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNegAudio : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 3.0f);
	}
}
