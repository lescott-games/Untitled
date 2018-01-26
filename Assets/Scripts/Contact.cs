using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour {

	public enum ContactType { Positive, Negative };

	public ContactType ctype = ContactType.Positive;
	public float climit = 7;

	private float timer;
	private float timeMinutes;
	private float timeSeconds;
	private bool tog;
	private Renderer rend;
	private TextMesh tm;

	// Use this for initialization
	void Start () {
		tog = false;
		rend = gameObject.GetComponent<Renderer> ();
		rend.material.color = Color.yellow;
		tm = transform.GetChild (0).GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timeMinutes = Mathf.FloorToInt (timer / 60f);
		timeSeconds = Mathf.FloorToInt (timer - timeMinutes * 60);
		tm.text = (climit - timeSeconds).ToString();

		if (timeSeconds >= climit) {
			ChangeType (tog);
		}
	}

	void ChangeType (bool t) {
		if (tog == false) {
			ctype = ContactType.Negative;
			rend.material.color = Color.magenta;
		}
	}

}
