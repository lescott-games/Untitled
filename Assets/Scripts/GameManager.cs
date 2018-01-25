using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public static float timer = 0;

	public GameObject[] responses;
	//public Camera mainCamera;
	public float gameDurationSeconds;
	[HideInInspector]
	public string niceTimer;
	public int timeSeconds;
	public int timeMinutes;
	public GameObject oContact;

	private Spawn spawnScript;
	private bool[] fingerArray = new bool[] { false, false, false, false, false };
	private GameObject[] contactArray = new GameObject[5];


	void Awake() {
		if (instance == null) {			// To enforce Singleton pattern for manager.
			instance = this;
			gameDurationSeconds = Random.Range (300, 500);
		} else if (instance != this) {
			Destroy (gameObject);
			gameDurationSeconds = instance.gameDurationSeconds;
		}

		DontDestroyOnLoad (gameObject);

	}

	// Use this for initialization
	void Start () {
		spawnScript = gameObject.GetComponent<Spawn> ();
	}

	// Update is called once per frame
	void Update () {

		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			// Get position of touch.
			// Spawn a Contact.
			switch (touch.phase)
			{
			case TouchPhase.Began:
				if (fingerArray[touch.fingerId] == false) {
					if (contactArray[touch.fingerId] == null) {
						Vector3 tp = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, 9));	
						contactArray [touch.fingerId] = Instantiate(oContact, tp, Quaternion.identity) as GameObject;
						print ("Created!");
						fingerArray [touch.fingerId] = true;
					}
				}
				break;

			case TouchPhase.Moved:
				if (fingerArray [touch.fingerId] == true) {
					if (contactArray [touch.fingerId] != null) {
						contactArray [touch.fingerId].transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, 9));	
					}
				}
				break;

			case TouchPhase.Ended:
				if (fingerArray [touch.fingerId] == true) {
					if (contactArray [touch.fingerId] != null) {
						print (contactArray [touch.fingerId]);
						DestroyImmediate (contactArray [touch.fingerId], true);
						print ("Destroyed!");
						fingerArray [touch.fingerId] = false;
					}
				}
				break;
			}
			// Contact is positive until it reaches x point.
		}
		if (fingerCount > 0) {
			//print("User has " + fingerCount + " finger(s) touching the screen");
		}




		/*
		if (Input.GetButtonDown("Interact")) {
			Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			//Vector3 screenPoint = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
			RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));
			//RaycastHit2D hit = Physics2D.Raycast (new Vector2 (mainCamera.transform.position.x, mainCamera.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

			if (hit != null && hit.collider != null) {
				//print (hit.collider.name);
			} else {
				Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				//Vector3 sp = mainCamera.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
				spawnScript.SpawnResponse (sp, Quaternion.identity);
			}
		}
		*/

		timer += Time.deltaTime;
		timeMinutes = Mathf.FloorToInt (timer / 60f);
		timeSeconds = Mathf.FloorToInt (timer - timeMinutes * 60);
		niceTimer = string.Format ("{0:00}:{1:00}", timeMinutes, timeSeconds);
	}

	public void GameOver() {
		SceneManager.LoadScene("Title") ;
	}
		
}
