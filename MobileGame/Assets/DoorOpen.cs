using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D Coll)
	{
		int i = PlayerPrefs.GetInt ("Key");
		switch (i) {
		case 1:
			PlayerPrefs.SetInt ("Key", 0);
			Destroy (gameObject);
			break;
		}
	}
}
