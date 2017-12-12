using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class ILongBoundingBox : MonoBehaviour {

	public ILong parent; 

	private SkeletonAnimation skeletonAnimation;


	void OnMouseDown() {
		parent.OnChildMouseDown ();
	}

	void OnMouseUp(){
		parent.OnChildMouseUp ();
	}
}
