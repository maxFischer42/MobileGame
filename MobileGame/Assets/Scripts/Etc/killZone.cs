using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour {


	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D Coll)
	{
		if (Coll.gameObject.layer == 9) {
			Vector2 LastCheck = new Vector2 (PlayerPrefs.GetFloat ("X"), PlayerPrefs.GetFloat ("Y"));
			transform.SetPositionAndRotation (LastCheck, Quaternion.identity);
		}
	}
}
