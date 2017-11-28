using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

	public Background background;

	private Color initial;
	private Color tmp;
	private Renderer rend;
	private Background bg;

	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<Renderer> ();
		initial = rend.material.color;
		print ("Initial color: " + initial);
		bg = background.GetComponent<Background> ();
	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.touchCount > 1 || Input.GetMouseButton (0) == true
		    || Input.GetMouseButton (1) == true)) {

			tmp = bg.GetComponent<Renderer>().material.color;
			tmp = tmp - new Color (0.1f, 0.1f, 0.1f);
			rend.material.color = tmp;
			print ("Border color: " + rend.material.color);

		} else {
			rend.material.color = bg.GetComponent<Renderer>().material.color;
			print ("Border color: " + rend.material.color);
		}

	}
}
