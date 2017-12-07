using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class TouchRadiate : MonoBehaviour {

	[SpineEvent] public string animationEventName = "animation";
	SkeletonAnimation skeletonAnimation;
	MeshRenderer meshRenderer;

	// Use this for initialization
	void Start () {
		skeletonAnimation = GetComponent<SkeletonAnimation> ();
		skeletonAnimation.state.SetAnimation (0, "animation", true);
		meshRenderer = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 1 || Input.GetMouseButton (0) == true
		    || Input.GetMouseButton (1) == true)) {
			Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

			if (hit != null && hit.collider != null) {
				print (hit.collider.name);
			} else {
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				// Touch effect here.
				gameObject.transform.position = sp;
				gameObject.transform.rotation = Quaternion.identity;
				//skeletonAnimation.state.SetAnimation (0, "animation", true);
				meshRenderer.enabled = true;
			}
		} else {
			// gameObject.GetComponent<ParticleSystem> ().Stop ();
			meshRenderer.enabled = false;
		}
	}

}
