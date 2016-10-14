using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Jitter : AsteroidMover {
	public override void move(Transform hazard){
		//standard straight
		hazard.position += hazard.forward * 0.1f;

		//adds the jitter
		Vector3 jit = new Vector3 (UnityEngine.Random.Range (-0.03f, 0.03f), UnityEngine.Random.Range (-0.03f, 0.03f), UnityEngine.Random.Range (-0.03f, 0.03f));
		hazard.position += jit;
	}
}
