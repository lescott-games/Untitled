using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRadiate : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
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
				if (!gameObject.GetComponent<ParticleSystem> ().isEmitting) {
					gameObject.GetComponent<ParticleSystem> ().Play ();
				}
			}
		} else {
			gameObject.GetComponent<ParticleSystem> ().Stop ();
		}
	}

}
