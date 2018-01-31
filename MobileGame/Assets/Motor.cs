using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {

	public virtualJoystick Joystick;
	public Vector3 MoveVector;
	public Rigidbody2D Rig;
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveVector = PoolInput ();
		Move ();
	}


	private Vector3 PoolInput()
	{
		Vector3 dir = Vector3.zero;
		dir.x = Joystick.Horizontal ();
		dir.y = Joystick.Vertical ();

		if (dir.magnitude > 1)
			dir.Normalize ();

		return dir;


	}

	private void Move()
	{
		Rig.velocity = MoveVector * speed;
	}

}
