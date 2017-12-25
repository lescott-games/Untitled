using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchReactTest : MonoBehaviour {

	public FingerCircle[] fingerCircleList;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			int modifiedFingerID = touch.fingerId + 1;
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				fingerCount++;
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, 9));
				if (fingerCircleList [modifiedFingerID] != null) {
					fingerCircleList [modifiedFingerID].transform.position = sp;
					fingerCircleList [modifiedFingerID].GetComponent<MeshRenderer> ().enabled = true;
				}
				print ("Modified fingerID: " + modifiedFingerID + ", Transform position: " + fingerCircleList [modifiedFingerID].transform.position);
			} else {
				fingerCircleList [modifiedFingerID].GetComponent<MeshRenderer> ().enabled = false;
			}

		}
		if (fingerCount > 0)
			print("User has " + fingerCount + " finger(s) touching the screen");
	}
		
}
