using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour {

	public GameObject Feet;
	public GameObject AboveFeet;

		void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag != "Bucket" || Coll.gameObject.layer != 8) {
			Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
			Rig.gravityScale = (Mathf.Abs (Rig.gravityScale)) * -1;
			Feet.SetActive (false);
			AboveFeet.SetActive (true);
				

		} else if(Coll.gameObject.tag == "Bucket"){
			Debug.Log ("Boosted");
			Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
			Rig.AddForce (new Vector2(0, 350));

		}
	}

	void OnTriggerExit2D(Collider2D Coll){
		if (Coll.gameObject.tag != "Bucket" && Coll.gameObject.layer != 8) {
			Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
			Rig.gravityScale = 3;
			Feet.SetActive (true);
			AboveFeet.SetActive (false);
		}
	}

}
