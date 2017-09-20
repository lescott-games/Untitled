using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour {

	public Color initialColor = Color.red;
	public Color bottomColor = Color.blue;
	public Color newColor = Color.blue;
	public float initialDuration = 0.0f;
	public float downShift = 0.0f;
	public float upShift = 0.0f;
	public Light mainLight;
	public GameManager gameManager;

	private float gameDuration;
	private float initialShift = 0.0f;
	private Renderer rend;
	private float gameShift = 0.0f;
	private Scene currentScene; 


	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
		rend.material.color = initialColor;
		gameDuration = gameManager.gameDurationSeconds;
		currentScene = SceneManager.GetActiveScene ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentScene.name == "Main") {
			if (initialShift <= 1) {
				rend.material.color = Color.Lerp (initialColor, bottomColor, initialShift);
				initialShift += Time.deltaTime * (1 / initialDuration);
				mainLight.intensity -= 0.01f;
			} else if (Input.GetButton ("Interact")) {
				rend.material.color = Color.Lerp (bottomColor, newColor, gameShift);
				gameShift += Time.deltaTime * (1 / gameDuration);
				gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
				if (gameShift >= 0.75f) {
					mainLight.intensity += 0.001f;
					mainLight.intensity = Mathf.Clamp (mainLight.intensity, 0.0f, 0.75f);
				} else {
					mainLight.intensity += 0.0001f;
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
		gameShift -= (Time.deltaTime * (1 / gameDuration)) * downShift;
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity -= 0.001f;
	}

	public void ShiftUp()
	{
		rend.material.color = Color.Lerp (newColor, bottomColor, gameShift);
		gameShift += (Time.deltaTime * (1 / gameDuration)) * upShift;
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity += 0.001f;
	}
}
