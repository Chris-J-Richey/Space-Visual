using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	ArrayList FieldObjects = new ArrayList();

	public GameObject hazard;

	void OnTriggerEnter (Collider other){
		if (other.tag == "Asteroid") {
			FieldObjects.Add (other.gameObject);
		}
	}
	void OnTriggerExit (Collider other){
		if (other.tag == "Asteroid") {
			FieldObjects.Remove (other.gameObject);
		}
	}

	void FixedUpdate () {
		for (int i = 0; i < FieldObjects.Count; i++) {
			if (FieldObjects [i].Equals (null)) {
				FieldObjects.Remove (FieldObjects [i]);
				return;
			}

			hazard = (GameObject)FieldObjects [i];

			Vector3 diff = hazard.transform.position - transform.position;

			diff.Normalize ();

			hazard.transform.position -= diff * .02f;
		}
	}
}
