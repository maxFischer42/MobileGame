using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontchangegrav : MonoBehaviour {

	private Rigidbody2D Rig;
	// Use this for initialization
	void Start () {
		Rig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Rig.gravityScale = 1;
	}
}
