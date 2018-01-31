using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour {

	public Rigidbody2D Rig;
	public float speed;
	public float jumpspeed;
	public bool grounded;
	public bool direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 vel = Rig.velocity;
		float x = Input.GetAxis ("Horizontal");
		vel = new Vector2 (x * speed, vel.y);
		float y = Input.GetAxis ("Jump");

		if (x > 0) {
			direction = true;
		} else if (x < 0) {
			direction = false;
		}

		if (y > 0 && grounded) {
			vel = new Vector2 (vel.x, y * jumpspeed);
			grounded = false;
		}

		Rig.velocity = vel;
	}
}
