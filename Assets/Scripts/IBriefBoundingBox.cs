using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class IBriefBoundingBox : MonoBehaviour {

	public IBrief parent; 

	private SkeletonAnimation skeletonAnimation;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		parent.OnChildMouseDown ();
	}
		
	void OnMouseUp(){
		parent.OnChildMouseUp ();
	}
}
