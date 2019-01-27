using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject monster;
	public GameObject[] spawnLocations;

	public int spawnFrames = 1000;
	public int actualFrames;
	public int rampDown = 50;

	// Start is called before the first frame update
	void Start()
    {
		actualFrames = spawnFrames;
		spawnLocations = GameObject.FindGameObjectsWithTag("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
		actualFrames--;
		if (actualFrames <= 0) {
			foreach (GameObject obj in spawnLocations) {
				if (obj.GetComponent<SpawnLocation>().isOutRange) {
					Debug.Log("Spawn");
					Instantiate(monster, obj.GetComponent<SpawnLocation>().pos, Quaternion.identity);
				}
			}

			actualFrames = spawnFrames;
			spawnFrames -= rampDown;
		}

    }
}
