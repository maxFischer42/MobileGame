using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createLava : MonoBehaviour {

	public GameObject lava;

	void OnDestroy()
	{
		lava.SetActive (true);
	}
}
