using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserk : MonoBehaviour {

	public float speed = 10;
	public Vector3 centerPt;
	public float radius;
	public float radiusShrinkRate;
	public float changeRate;
	public float rateIncrease;

	private Vector3 direction;
	private Vector3 movement;

	// Use this for initialization
	void Start () {
		centerPt = transform.position;
		movement = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), 0.0f).normalized;
		StartCoroutine(ChangeDirection());
	}
	
	// Update is called once per frame
	void Update () { 
		movement = direction;
		Vector3 newPos = transform.position + movement;
		Vector3 offset = newPos - centerPt;
		//transform.position += direction * speed * Time.deltaTime;
		transform.position = centerPt + Vector3.ClampMagnitude(offset, radius);
		// make sure that the position is never outside of a certain radius of where the object spawned.
		changeRate -= rateIncrease;
		radius -= radiusShrinkRate;

		if ((Input.touchCount > 1 || Input.GetMouseButton (0) == true
			|| Input.GetMouseButton (1) == true)) {

			Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

			if (hit != null && hit.collider != null) {
				print (hit.collider.name);
			} else {
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				centerPt = sp;
				//gameObject.transform.rotation = Quaternion.identity;
			}

		}

	}

	IEnumerator ChangeDirection() {
		while (true) {
			print ("Changing direction");
			yield return new WaitForSeconds (changeRate);
			direction = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), 0.0f).normalized;
			print ("Changed direction");
		}
	}
}
