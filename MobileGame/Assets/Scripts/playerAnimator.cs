using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour {

	public RuntimeAnimatorController Move;
	public RuntimeAnimatorController Attack;

	private SwordBehavior sword;
	private Rigidbody2D Rig;
	private Animator Anim;
	private SpriteRenderer Sprt;

	// Use this for initialization
	void Start () {
		Rig = GetComponent<Rigidbody2D> ();
		Anim = GetComponent<Animator> ();
		sword = GetComponent<SwordBehavior> ();
		Sprt = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {



		float x = Rig.velocity.x;


		if (x > 0) {
			Sprt.flipX = false;
		} else if (x < 0) {
			Sprt.flipX = true;
		}
		x = Mathf.Abs (x);
		if (x > 1 && sword.attacking != true) {
			Anim.enabled = true;


				if (sword.attacking != true) {
					Anim.runtimeAnimatorController = Move;
				}
		} else if (x == 0 || sword.attacking != true) {
			Anim.enabled = false;

		}
		if (sword.attacking) {
			Anim.enabled = true;
			Anim.runtimeAnimatorController = Attack;
		}

	}
}
