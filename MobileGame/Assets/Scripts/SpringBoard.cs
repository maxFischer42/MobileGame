using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBoard : MonoBehaviour {

	public SpriteRenderer Sprt;
	public Animator Spring;
	public Sprite IdleSpring;
	bool colliding;
	float timer;
	public Rigidbody2D Rig;
	public Vector2 directionSpeed;

	
	// Update is called once per frame
	void Update () {
		if (colliding) {
			timer += Time.deltaTime;
			if (timer > 0.15) {
				Rig.AddForce (directionSpeed);
				timer = 0;
			}
		}
			
	}

	void OnTriggerEnter2D(Collider2D Coll){
		
			Rig = Coll.transform.parent.GetComponent<Rigidbody2D>();
			colliding = true;
			Spring.enabled = true;
			colliding = true;
		
	}

	void OnTriggerExit2D(Collider2D Coll)
	{
		colliding = false;
		Spring.enabled = false;
		Sprt.sprite = IdleSpring;
	}
}
