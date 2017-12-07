using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class IBrief : MonoBehaviour {

	private GameObject background;
	private Background bgScript;
	//private SpriteRenderer sr;
	private SkeletonAnimation skeletonAnimation;

	//public int colorChange = 20;

	// Use this for initialization
	void Start () {
		background = GameObject.FindGameObjectWithTag ("Background");
		bgScript = background.GetComponent<Background> ();
		// sr = gameObject.GetComponent<SpriteRenderer> ();
		//print ("Initial color: " + sr.color);
		skeletonAnimation = GetComponent<SkeletonAnimation> ();
		skeletonAnimation.state.SetAnimation (0, "idle", true);
		//Destroy (gameObject, 4.0f);
	}

	void Update () {
		if ((Input.touchCount > 1 || Input.GetMouseButton (0) == true
			|| Input.GetMouseButton (1) == true)) {
			Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

			if (hit != null && hit.collider != null) {
				//print (hit.collider.name);
			} else {
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				// Touch effect here.
				//gameObject.transform.position = sp;
				//gameObject.transform.rotation = Quaternion.identity;
			}
		} else {
			// gameObject.GetComponent<ParticleSystem> ().Stop ();
			skeletonAnimation.state.SetAnimation (0, "idle", true);
			print ("IBrief deactivated");
		}
	}

	void OnMouseDrag () {
		bgScript.ShiftUp ();
	}

	void OnMouseDown() {
		//sr.color = Color.gray;
		skeletonAnimation.state.SetAnimation (0, "activated", true);
		print ("IBrief activated");
	}

	void OnMouseUp(){
		//sr.color = Color.white;
		skeletonAnimation.state.SetAnimation (0, "idle", true);
		print ("IBrief deactivated");
	}
}
