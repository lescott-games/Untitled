using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	public Text continueText;
	public float textBlink;
	public GameObject background;

	private float initialColor;
	private Background bgScript;
	private Renderer bgRenderer;


	// Use this for initialization
	void Start () {
		bgRenderer = background.GetComponent<Renderer> ();
		bgScript = background.GetComponent<Background> ();
		bgRenderer.material.color = bgScript.initialColor;
	}
	
	// Update is called once per frame
	void Update () {
		textBlink = Random.value;
		continueText.color = Color.Lerp (Color.black, Color.white, textBlink);

		if (Input.anyKeyDown)
			SceneManager.LoadScene ("Main");
			
	}
}
