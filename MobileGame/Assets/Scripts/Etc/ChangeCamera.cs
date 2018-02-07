using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

	public GameObject BucketCam;
	public GameObject MainCam;

	public virtualJoystick old;
	public Canvas can;



	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			BucketCam.SetActive (true);
			MainCam.SetActive (false);
			can.worldCamera = BucketCam.GetComponent<Camera>();
		}
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
			if(Coll.gameObject.tag == "Player"){
			can.worldCamera = MainCam.GetComponent<Camera>();
		MainCam.SetActive (true);
		BucketCam.SetActive (false);

			}

	}
}
