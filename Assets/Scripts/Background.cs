using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour {

	public Color initialColor = Color.red;
	public Color bottomColor = Color.blue;
	public Color newColor = Color.blue;
	public float initialDuration = 0.0f;
	//public float downShift = 0.0f;
	//public float upShift = 0.0f;
	public Light mainLight;
	//public GameManager gameManager;
	public float contactLimit = 0.0f;
	public GameObject RTooMuch;
	[HideInInspector]
	public float gameShift = 0.0f;
	public float shiftSpeedMultiplier;
	public float timeHeldDown;
	public float touchTime = 0;

	private float gameDuration;
	private float initialShift = 0.0f;
	private Renderer rend;
	private Scene currentScene; 
	private float touchDown;
	private float touchUp;
	private int fps = 60;
	private GameManager gameManager;
	private Spawn spawn;
	private float shiftSpeed;
	private bool contactLimitToggle = true;
	private Spawn spawnScript;



	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
		rend.material.color = initialColor;
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager> ();
		gameDuration = gameManager.gameDurationSeconds;
		currentScene = SceneManager.GetActiveScene ();
		//print ("Game duration: " + 1/(gameDuration*fps));
		spawn = gameManager.GetComponent<Spawn> ();
		spawn.ResetComponents ();
		shiftSpeed = (1 / (gameDuration * fps));
		if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android) {
			shiftSpeed = shiftSpeed * 2;
		}
		spawnScript = gameObject.GetComponent<Spawn> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentScene.name == "Main") {
			if (initialShift <= 1) {
				rend.material.color = Color.Lerp (initialColor, bottomColor, initialShift);
				initialShift += Time.deltaTime * (1 / initialDuration);
				mainLight.intensity -= 0.01f;
			} else if ((Input.touchCount > 1 || Input.GetMouseButton(0) == true 
				|| Input.GetMouseButton(1) == true)) {
				rend.material.color = Color.Lerp (bottomColor, newColor, gameShift);
				//gameShift += (1 / (gameDuration*fps));
				gameShift += shiftSpeed;
				//gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
				if (gameShift >= 0.75f) {
					mainLight.intensity += 0.001f;
					mainLight.intensity = Mathf.Clamp (mainLight.intensity, 0.0f, 0.75f);
				} else {
					mainLight.intensity += 0.0001f;
				}

				touchTime += Time.deltaTime;
				int minutes = Mathf.FloorToInt (touchTime / 60f);
				int seconds = Mathf.FloorToInt (touchTime - minutes * 60);

			

				if (touchTime >= contactLimit) {
					print ("Should spawn an RTooMuch.");
			
					touchTime = 0;
					Vector3 screenPoint = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 1));
					RaycastHit2D hit = Physics2D.Raycast (new Vector2 (Camera.main.transform.position.x, Camera.main.transform.position.y), new Vector2 (screenPoint.x, screenPoint.y));

					if (hit != null && hit.collider != null) {
						print (hit.collider.name);
					} else {
						Vector3 sp = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z + 9));
						Instantiate (RTooMuch, sp, Quaternion.identity);
					}
				} 
				
			}
			//Debug.Log ("Game shift: " + gameShift);
			//Debug.Log ("Game shift time: " + gameShift * 10);
			//Debug.Log ("Game duration: " + gameDuration);
		}

	}

	public void ReverseShift()
	{
		rend.material.color = Color.Lerp (bottomColor, newColor, gameShift);
		//gameShift -= (Time.deltaTime * (1 / gameDuration)) * upShift;
		gameShift -= shiftSpeed;
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity -= 0.0001f;
	}

	public void ShiftUp()
	{
		rend.material.color = Color.Lerp (newColor, bottomColor, gameShift);
		gameShift += shiftSpeed;
		//gameShift += (Time.deltaTime * (1 / gameDuration)) * upShift;
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity += 0.0001f;
	}

	void OnMouseDown() {
		touchDown = Time.time;
	}

	void OnMouseUp() {
		touchUp = Time.time;
		timeHeldDown += touchUp - touchDown;
		print ("Time held down: " + timeHeldDown);
		print ("Game shift: " + gameShift);
		touchTime = 0;
	}
}
