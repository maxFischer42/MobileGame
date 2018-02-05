using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

	public GameObject BucketCam;
	public GameObject MainCam;



	void OnTriggerEnter2D(Collider2D Coll)
	{
		BucketCam.SetActive (true);
		MainCam.SetActive (false);
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		MainCam.SetActive (true);
		BucketCam.SetActive (false);

	}
}
