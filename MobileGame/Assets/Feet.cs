using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour {

	public PlatformerController Plat;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == 8) {
			//layer 8 is ground
			Plat.grounded = true;
		}
	}




	void OnTriggerStay2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == 8) {
			//layer 8 is ground
			Plat.grounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == 8) {
			//layer 8 is ground
			Plat.grounded = false;
		}
	}
}
