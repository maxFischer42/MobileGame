using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.tag == "Player") {
			GameObject.Find ("DZ").gameObject.GetComponent<DeadZone> ().Spawn = transform.position;
			Destroy (gameObject);
		}
	}
}
