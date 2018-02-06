using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

	public GameObject BucketCam;
	public GameObject MainCam;

	public virtualJoystick old;
	public virtualJoystick newe;



	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			BucketCam.SetActive (true);
			MainCam.SetActive (false);
			Coll.gameObject.GetComponent<PlatformerController> ().Joystick = newe;
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
			if(Coll.gameObject.tag == "Player"){
			Coll.gameObject.GetComponent<PlatformerController> ().Joystick = old;
		MainCam.SetActive (true);
		BucketCam.SetActive (false);

			}

	}
}
