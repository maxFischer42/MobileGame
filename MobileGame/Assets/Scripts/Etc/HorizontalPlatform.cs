using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatform : MonoBehaviour {

	public float multiplier = -30f;



	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			Coll.transform.SetParent (transform);
		}
	}
		
	void OnCollisionStay2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			Coll.gameObject.GetComponent<Rigidbody2D>().AddForce(GetComponent<MovingPlatform>().Direction * multiplier);

		}
	}

	void OnCollisionExit2D(Collision2D Coll)
	{
		
		if (Coll.gameObject.tag == "Player") {
			Coll.transform.SetParent (null);
		}
	}
}
