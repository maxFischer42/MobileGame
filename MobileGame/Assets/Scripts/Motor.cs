using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {

	public PlatformerController Plat;
	public virtualJoystick Joystick;
	public Rigidbody2D Rig;
	public Vector3 MoveVector;
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

		if (dir.magnitude > 1)
			dir.Normalize ();

		if (dir.x > 0) {
			Plat.direction = true;
		} else if (dir.x < 0) {
			Plat.direction = false;
		}
		dir = new Vector2 (dir.x, Plat.aaa.y);
		return dir;


	}

	private void Move()
	{
		Rig.velocity = MoveVector * speed;
	}

}
