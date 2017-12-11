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
