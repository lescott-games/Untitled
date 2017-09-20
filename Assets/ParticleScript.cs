using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

	[Range(10, 30)]
	public int resolution = 10;

	public enum FunctionOption{
		Linear,
		Exponential,
		Parabola,
		Sine,
		Ripple
	}

	public FunctionOption function;

	private ParticleSystem m_System;
	private ParticleSystem.Particle[] points;
	private delegate float FunctionDelegate(Vector3 p, float t);
	private static FunctionDelegate[] functionDelegates = {
		Linear,
		Exponential,
		Parabola,
		Sine,
		Ripple
	};

	private int currentResolution;


	private void Update() {
		if (currentResolution != resolution || points == null) {
			CreatePoints ();
		}
		//FunctionDelegate f = functionDelegates[(int)function];
		float t = Time.timeSinceLevelLoad;
		int z = (int)Mathf.RoundToInt (t);
		int q = 1;
		print (q.GetType());
		//for (int i = 0; i < points.Length; i++) {
		//	Color c = points [i].color;
		//	c.a = f (points [i].position, t);
		//	points [i].color = c;
		//}
		points[(int)Mathf.Sin(z)].color = new Color(0f, 0f, 0f);
		m_System.SetParticles(points, points.Length);

		//if (Input.GetButtonDown ("Interact")) {
		//	RippleOnce ();
		//}

	}

	private static float Linear(Vector3 p, float t){
		return 1f - p.x - p.y + 0.5f * Mathf.Sin(t);
	}

	private static float Exponential (Vector3 p, float t) {
		return 1f - p.x * p.x - p.y * p.y + 0.5f * Mathf.Sin(t);
	}

	private static float Parabola (Vector3 p, float t){
		p.x += p.x - 1f;
		return 1f - p.x * p.x;
	}

	private static float Sine (Vector3 p, float t){
		float x = Mathf.Sin(2 * Mathf.PI * p.x);
		float y = Mathf.Sin(2 * Mathf.PI * p.y + (p.y > 0.5f ? t : -t));
		return x * x * y * y;
	}

	private void WaveOnce (Vector3 p, float t){
		float x = Mathf.Sin(2 * Mathf.PI * p.x);
		float y = Mathf.Sin(2 * Mathf.PI * p.y + (p.y > 0.5f ? t : -t));
	}

	private static float Ripple (Vector3 p, float t){
		p.x -= 0.5f;
		p.y -= 0.5f;
		float squareRadius = p.x * p.x + p.y * p.y;
		return Mathf.Sin(4f * Mathf.PI * squareRadius - 2f * t);
	}

	private void RippleOnce (){
		for (float j = 0f; j < 1f; j = j + 0.01f) {	
			for (int i = 0; i < points.Length; i++) {
				Vector3 pos = points [i].position;
				Color c = points [i].color;
				float squareRadius = pos.x * pos.x + pos.y * pos.y;
				c.a = Mathf.Sin(4f * Mathf.PI * squareRadius - 2f * j);
				points [i].color = c;
			}
			m_System.SetParticles(points, points.Length);
		}
	}

	void Start()
	{
		m_System = GetComponent<ParticleSystem> ();
	}


	private void CreatePoints()
	{
		currentResolution = resolution;
		points = new ParticleSystem.Particle[resolution * resolution * resolution];
		float increment = 1f / (resolution - 1);
		int i = 0;
		for (int x = 0; x < resolution; x++){
				for (int y = 0; y < resolution; y++) {
					Vector3 p = new Vector3 (x, y, 0f) * increment;
					//print (x + "," + y + "," + z);
					points [i].position = p;
					points [i].color = new Color (0.1f*p.x, 0.1f*p.y, 0f);
					points [i++].size = 0.1f;
				}
		}

	}
}

