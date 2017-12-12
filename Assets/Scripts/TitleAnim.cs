using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class TitleAnim : MonoBehaviour {

	public float dripRate = 7.0f;

	private SkeletonGraphic skeletonGraphic;
	private PolygonCollider2D collider;

	// Use this for initialization
	void Start () {
		skeletonGraphic = GetComponent<SkeletonGraphic> ();
		skeletonGraphic.AnimationState.SetAnimation (0, "idle", false);
		collider = GetComponentInChildren<PolygonCollider2D> ();
		StartCoroutine(AnimTitle());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator AnimTitle() {
		while (true) {
			yield return new WaitForSeconds (dripRate);
			skeletonGraphic.AnimationState.SetAnimation (0, "y-drip", false);
		}
	}
}
