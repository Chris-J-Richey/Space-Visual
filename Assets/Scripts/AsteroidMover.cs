using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public abstract class AsteroidMover{
	public abstract void move(Transform hazard);
}
