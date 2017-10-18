using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	// Here's where we define our weighted object structure,
	// and flag it Serializable so it can be edited in the Inspector.
	[System.Serializable]
	public struct Spawnable
	{
		public GameObject gameObject;
		public float weight;
	}

	// Now expose an array of these to be populated in the Inspector.
	public Spawnable[] spawnList;

	//public float phase1 = 0.0f;
	public float phase2 = 0.16f;
	public float phase3 = 0.25f;
	public float phase4 = 0.5f;
	public float phase5 = 0.75f;
	public float phase6 = 0.99f;

	[HideInInspector]
	public string phase;

	// Track the total weight used in the whole array.
	private float _totalSpawnWeight;

	private float gameShift;
	//private GameManager gameManager;
	private GameObject bg;
	//private int fps = 60;

	// Update the total weight when the user modifies Inspector properties,
	// and on initialization at runtime.
	void OnValidate()
	{
		_totalSpawnWeight = 0f;
		foreach(var spawnable in spawnList)	{
			_totalSpawnWeight += spawnable.weight;
			//print ("Spawn weight incremented by " + spawnable.weight);
			//print ("Total spawn weight: " + _totalSpawnWeight);
		}
		//print ("Total spawn weight at end of OnValidate: " + _totalSpawnWeight);
	}

	// As Problematic points out below, OnValidate isn't called
	// in a built executable. But in that case we don't need to react
	// to a user fiddling with the Inspector mid-game, so it suffices
	// to run this code once during Awake:
	void Awake()
	{
		//OnValidate();
		//gameManager = gameObject.GetComponent<GameManager> ();
		bg = GameObject.FindGameObjectWithTag ("Background");
	}

	void Start()
	{
		OnValidate ();
	}
		

	public void ResetComponents()
	{
		//OnValidate();
		//gameManager = gameObject.GetComponent<GameManager> ();
		bg = GameObject.FindGameObjectWithTag ("Background");
		//print ("Components reset");
	}

	void Update() 
	{
		//gameShift += 1 / (gameManager.gameDurationSeconds * fps);
		gameShift = bg.GetComponent<Background>().gameShift;
		ChangeWeights (gameShift);
		//print ("Spawn game shift: " + gameShift);
		//print ("Total spawn weight 0: " + _totalSpawnWeight);

	}

	// Spawn an item randomly, according to the relative weights.
	public void SpawnResponse(Vector3 pos, Quaternion qua)
	{
		//print ("Total spawn weight 1: " + _totalSpawnWeight);
		// Generate a random position in the list.
		float pick = Random.value * _totalSpawnWeight;
		int chosenIndex = 0;
		float cumulativeWeight = spawnList[0].weight;
		//print ("Pick: " + pick);
		//print ("Cumulative weight: " + cumulativeWeight);
		//print ("Total spawn weight 2: " + _totalSpawnWeight);


		// Step through the list until we've accumulated more weight than this.
		// The length check is for safety in case rounding errors accumulate.
		while(pick > cumulativeWeight && chosenIndex < spawnList.Length - 1)
		{
			chosenIndex++;
			cumulativeWeight += spawnList[chosenIndex].weight;
			//print ("Cum weight 2: " + cumulativeWeight);
		}

		// Spawn the chosen item.
		Instantiate(spawnList[chosenIndex].gameObject, pos, qua);
	}

	public void ChangeWeights(float shift)
	{
		if (shift > 0f && shift <= phase2) {
			spawnList [0].weight = 5f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 0f;
			spawnList [3].weight = 0f;
			spawnList [4].weight = 0f;
			spawnList [5].weight = 0f;
			spawnList [6].weight = 0f;
			spawnList [7].weight = 0f;
			spawnList [8].weight = 0f;
			spawnList [9].weight = 0f;
			spawnList [10].weight = 0f;
			phase = "1";
		} else if (shift > phase2 && shift <= phase3) {
			spawnList [0].weight = 3f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 1f;
			spawnList [3].weight = 0f;
			spawnList [4].weight = 0f;
			spawnList [5].weight = 0f;
			spawnList [6].weight = 0f;
			spawnList [7].weight = 0f;
			spawnList [8].weight = 0f;
			spawnList [9].weight = 0f;
			spawnList [10].weight = 0f;
			phase = "2";
		} else if (shift > phase3 && shift <= phase4) {
			spawnList [0].weight = 2f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 1f;
			spawnList [3].weight = 1f;
			spawnList [4].weight = 1f;
			spawnList [5].weight = 1f;
			spawnList [6].weight = 0f;
			spawnList [7].weight = 0f;
			spawnList [8].weight = 0f;
			spawnList [9].weight = 0f;
			spawnList [10].weight = 0f;
			phase = "3";
		} else if (shift > phase4 && shift <= phase5) {
			spawnList [0].weight = 1f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 2f;
			spawnList [3].weight = 2f;
			spawnList [4].weight = 2f;
			spawnList [5].weight = 1f;
			spawnList [6].weight = 1f;
			spawnList [7].weight = 1f;
			spawnList [8].weight = 0f;
			spawnList [9].weight = 0f;
			spawnList [10].weight = 0f;
			phase = "4";
		} else if (shift > phase5 && shift <= phase6) {
			spawnList [0].weight = 1f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 1f;
			spawnList [3].weight = 1f;
			spawnList [4].weight = 1f;
			spawnList [5].weight = 1f;
			spawnList [6].weight = 1f;
			spawnList [7].weight = 2f;
			spawnList [8].weight = 2f;
			spawnList [9].weight = 2f;
			spawnList [10].weight = 0f;
			phase = "5";
		} else if (shift > phase6) {
			spawnList [0].weight = 1f;
			spawnList [1].weight = 1f;
			spawnList [2].weight = 1f;
			spawnList [3].weight = 1f;
			spawnList [4].weight = 1f;
			spawnList [5].weight = 1f;
			spawnList [6].weight = 1f;
			spawnList [7].weight = 1f;
			spawnList [8].weight = 1f;
			spawnList [9].weight = 1f;
			spawnList [10].weight = 10f;
			phase = "6, Finished";
		}

		_totalSpawnWeight = 0f;
		foreach(var spawnable in spawnList)	{
			_totalSpawnWeight += spawnable.weight;
			//print ("Spawn weight incremented by " + spawnable.weight + " in ChangeWeights");
			//print ("Total spawn weight: " + _totalSpawnWeight);
		}
		//print ("Total spawn weight at end of ChangeWeights: " + _totalSpawnWeight);

	}

}
