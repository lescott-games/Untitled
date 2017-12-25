using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class FingerCircle : MonoBehaviour {

	public int ID;

	private SkeletonAnimation skeletonAnimation;

	// Use this for initialization
	void Start () {
		skeletonAnimation = GetComponent<SkeletonAnimation> ();
		skeletonAnimation.state.SetAnimation (0, "idle", true);
		gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
