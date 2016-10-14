using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour{
	public AsteroidMover mover = new Straight();

	void FixedUpdate (){
		Debug.Log (mover);
		mover.move(transform);
	}
}
