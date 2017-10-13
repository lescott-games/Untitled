using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public GameObject[] responses;
	//public Camera mainCamera;
	public float gameDurationSeconds;

	private Spawn spawnScript;
	private float timeHeldDown;
	private float touchDown;
	private float touchUp;


	void Awake() {
		if (instance == null) {			// To enforce Singleton pattern for manager.
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	void Start () {
		spawnScript = gameObject.GetComponent<Spawn> ();
		gameDurationSeconds = Random.Range (300, 500);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact")) {
			Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			//Vector3 screenPoint = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));
			//RaycastHit2D hit = Physics2D.Raycast (new Vector2 (mainCamera.transform.position.x, mainCamera.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

			if (hit != null && hit.collider != null) {
				print (hit.collider.name);
			} else {
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				//Vector3 sp = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				spawnScript.SpawnResponse (sp, Quaternion.identity);
				print ("im on a plane");
				timeHeldDown = Time.deltaTime;
				print ("Time held down" + timeHeldDown);
			}
		}
	}

	void OnMouseDown() {
		touchDown = Time.time;
	}

	void OnMouseUp() {
		touchUp = Time.time;
		timeHeldDown += touchUp - touchDown;
	}
}
