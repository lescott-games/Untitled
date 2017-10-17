﻿using System.Collections;
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
	[HideInInspector]
	public float gameShift = 0.0f;
	public float shiftSpeedMultiplier;
	public float timeHeldDown;

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



	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
		rend.material.color = initialColor;
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager> ();
		gameDuration = gameManager.gameDurationSeconds;
		currentScene = SceneManager.GetActiveScene ();
		print ("Game duration: " + 1/(gameDuration*fps));
		spawn = gameManager.GetComponent<Spawn> ();
		spawn.ResetComponents ();
		shiftSpeed = (1 / (gameDuration * fps));
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
				//gameShift += (1 / (gameDuration*fps));
				gameShift += shiftSpeed;
				//gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
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
		//gameShift -= (Time.deltaTime * (1 / gameDuration)) * upShift;
		gameShift -= (shiftSpeed * shiftSpeedMultiplier);
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity -= 0.001f;
	}

	public void ShiftUp()
	{
		rend.material.color = Color.Lerp (newColor, bottomColor, gameShift);
		gameShift += (shiftSpeed * shiftSpeedMultiplier);
		//gameShift += (Time.deltaTime * (1 / gameDuration)) * upShift;
		gameShift = Mathf.Clamp (gameShift, 0.0f, 1.0f);
		mainLight.intensity += 0.001f;
	}

	void OnMouseDown() {
		touchDown = Time.time;
	}

	void OnMouseUp() {
		touchUp = Time.time;
		timeHeldDown += touchUp - touchDown;
		print ("Time held down: " + timeHeldDown);
		print ("Game shift: " + gameShift);
	}
}
