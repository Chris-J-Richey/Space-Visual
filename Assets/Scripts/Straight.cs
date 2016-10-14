using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Straight : AsteroidMover {
	public override void move(Transform hazard){
		//standard straight
		hazard.position += hazard.forward * 0.1f;
	}
}
