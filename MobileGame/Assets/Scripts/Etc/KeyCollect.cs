using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			PlayerPrefs.SetInt ("Key", 1);
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			PlayerPrefs.SetInt ("Key", 1);
			Destroy (gameObject);
		}
	}
}
