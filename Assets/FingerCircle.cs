using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class FingerCircle : MonoBehaviour {

	private SkeletonAnimation skeletonAnimation;

	// Use this for initialization
	void Start () {
		skeletonAnimation = GetComponent<SkeletonAnimation> ();
		skeletonAnimation.state.SetAnimation (0, "animation", true);
		//gameObject.GetComponent<MeshRenderer> ().enabled = false;
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//skeletonAnimation.skeleton.a -= 0.01f;
	}

	 
	void OnTriggerEnter2D (Collider2D other)
	{
		//print ("Triggering?");
		if(other.gameObject.tag == "FingerCircle")
		{
			print ("My collider: " + other.gameObject.name);
			print ("Their collider: " + other.gameObject.name);
		}
		//print ("Their collider: " + other.gameObject.name);
	}
}
