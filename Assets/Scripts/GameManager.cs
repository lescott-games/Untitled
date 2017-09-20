using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] responses;
	public Camera mainCamera;
	public float gameDurationSeconds;

	private Spawn spawnScript;

	// Use this for initialization
	void Start () {
		spawnScript = gameObject.GetComponent<Spawn> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact")) {
			Vector3 screenPoint = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (mainCamera.transform.position.x, mainCamera.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));
			if (hit != null && hit.collider != null) {
				print (hit.collider.name);
			} else {
				Vector3 sp = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				spawnScript.SpawnResponse (sp, Quaternion.identity);
			}
		}
	}
}
