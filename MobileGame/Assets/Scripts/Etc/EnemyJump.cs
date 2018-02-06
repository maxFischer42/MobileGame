using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour {

	public Rigidbody2D Rig;
	public float forceSpeed;
	public Vector2 givenTimer;
	private float current;
	private float timer = 0;
	public bool grounded;

	void Start()
	{
		current = Random.Range (givenTimer.x, givenTimer.y);
	}



	void Update()
	{
		if (grounded) {
			timer += Time.deltaTime;
			if (timer >= current) {
				Rig.AddForce (new Vector2 (0, forceSpeed));
				timer = 0;
				current = Random.Range (givenTimer.x, givenTimer.y);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		grounded = true;
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		grounded = false;
	}
}
