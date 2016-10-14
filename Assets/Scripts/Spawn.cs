using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	public GameObject hazard;

	public float spawnRate = .5f;

	void Start () {
		InvokeRepeating ("AsteroidSpawn", 0f, .5f);
	}

	void AsteroidSpawn () {
		Vector3 spawnPosition = new Vector3 (Random.Range(-10f, 10f), Random.Range(-10f, 10f), -12.5f);
		Object asteroid = Instantiate (hazard, spawnPosition, Quaternion.identity);
		GameObject asteroidGameObj = (GameObject)asteroid;
		Movement moveHazard = asteroidGameObj.GetComponent<Movement>();

		int chooser = Random.Range (1, 4);

		if (chooser == 1) {
			moveHazard.mover = new Straight();
		}else if (chooser == 2) {
			moveHazard.mover = new Jitter();
		}else {
			moveHazard.mover = new Euler();
		}
	}
}
