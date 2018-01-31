﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour {
	
	public virtualJoystick Joystick;
	public Rigidbody2D Rig;
	public float speed;
	public float jumpspeed;
	public bool grounded;
	public bool direction;
	public bool jump;
	public Vector2 aaa;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 dir = Vector3.zero;
		dir.x = Joystick.Horizontal ();
		//dir.y = Joystick.Vertical ();


		if (jump) {
			dir = new Vector2 (dir.x, jumpspeed);
			grounded = false;
			jump = false;
		}
		aaa = dir;
		Rig.velocity = dir;
	}


	public void JumpButton()
	{
		if (grounded) {
			jump = true;
			Debug.Log ("Jump");
		}
	}
}
