using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grief : MonoBehaviour {

	public float mass = 3f;
	public float entropy = 0f;
	public float contactLimit = 5f;
	public float breakingPoint = 10f;
	public GameManager gm;

	private Text entropyText;
	private Text contactLimitText;
	private Text winText;
	private Text loseText;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (mass, mass, 0);
		entropyText = GameObject.Find ("Entropy").GetComponent<Text>();
		contactLimitText = GameObject.Find ("ContactLimit").GetComponent<Text>();
		winText = GameObject.Find ("WinText").GetComponent<Text>();
		loseText = GameObject.Find ("LoseText").GetComponent<Text>();
		winText.text = "";
		loseText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		float x = 0;
		float y = 0;
		transform.localScale -= new Vector3(0.001F, 0.001F, 0);
		x = Mathf.Clamp (transform.localScale.x, 0f, 100f);
		y = Mathf.Clamp (transform.localScale.y, 0f, 100f);
		transform.localScale = new Vector3 (x, y, 0);
		entropy += 0.01f;
		entropyText.text = (Mathf.Round(entropy).ToString ()) + " / " + breakingPoint.ToString();
		contactLimitText.text = (Mathf.Round(contactLimit).ToString ());

		if (transform.localScale.x <= 0) {
			winText.text = "You win";
		}

		if (entropy >= breakingPoint) {
			loseText.text = "You lose";
			StartCoroutine(GameOver ());
		}
	}

	public void Decrease() {
		transform.localScale -= new Vector3(0.001F, 0.001F, 0);
	}

	public void Increase() {
		transform.localScale += new Vector3(0.002F, 0.002F, 0);
	}

	IEnumerator GameOver() {
		yield return new WaitForSeconds(5);
		gm.GameOver ();
	}
}
