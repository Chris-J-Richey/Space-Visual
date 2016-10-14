using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Euler : AsteroidMover {
	public override void move(Transform hazard){
		//standard straight
		hazard.position += hazard.forward * 0.1f;

		//sets angle
		if (hazard.rotation == Quaternion.identity) {
			Vector3 angle = hazard.rotation.eulerAngles;
			angle.x = UnityEngine.Random.Range (-3f, 3f);
			angle.y = UnityEngine.Random.Range (-3f, 3f);
			angle.z = UnityEngine.Random.Range (-3f, 3f);
			hazard.rotation = Quaternion.Euler (angle);
		}
	}
}
