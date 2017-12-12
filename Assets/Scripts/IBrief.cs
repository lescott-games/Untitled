﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class IBrief : MonoBehaviour {

	public float destroyTime = 3.0f;

	private GameObject background;
	private Background bgScript;
	private SkeletonAnimation skeletonAnimation;
	private PolygonCollider2D collider;


	void Start () {
		background = GameObject.FindGameObjectWithTag ("Background");
		bgScript = background.GetComponent<Background> ();
		skeletonAnimation = GetComponent<SkeletonAnimation> ();
		skeletonAnimation.state.SetAnimation (0, "idle", true);
		collider = GetComponentInChildren<PolygonCollider2D> ();
		Destroy (gameObject, destroyTime);
	}

	void Update () {
		
	}
		
	public void OnChildMouseDown() {
		skeletonAnimation.state.SetAnimation (0, "activated", true);
	}

	public void OnChildMouseUp() {
		skeletonAnimation.state.SetAnimation (0, "idle", true);
	}

}
