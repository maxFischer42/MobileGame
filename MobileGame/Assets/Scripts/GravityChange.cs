using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour {

	public bool direction;
	public GameObject Feet;
	public GameObject AboveFeet;

		void OnTriggerEnter2D(Collider2D Coll)
	{
		Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
		switch (direction) {
		case false:
			Rig.gravityScale = Mathf.Abs (Rig.gravityScale);
			break;
		case true:
			Rig.gravityScale = (Mathf.Abs (Rig.gravityScale)) * -1;
			Feet.SetActive (false);
			AboveFeet.SetActive (true);
			break;
		}
	}

	void OnTriggerExit2D(Collider2D Coll){
		Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
		Rig.gravityScale = 3;
		Feet.SetActive (true);
		AboveFeet.SetActive (false);
	}

}
