using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public Vector2 Direction;
	public float speed;
	public float time;
	private float timer;
	public Rigidbody2D rig;


	// Use this for initialization
	void Start ()
	{
		rig.velocity = new Vector2 (Direction.x * speed, Direction.y * speed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= time) {
			Direction *= -1;
			rig.velocity = new Vector2 (Direction.x * speed, Direction.y * speed);
			timer = 0;
		/*	if (gameObject.GetComponent<HorizontalPlatform> ())
			{
				GetComponent<HorizontalPlatform> ().multiplier *= -1;
			}*/
		}
	}
}
