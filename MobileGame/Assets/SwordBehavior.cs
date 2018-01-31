using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehavior : MonoBehaviour {

	private float timer;
	public float attacklength;
	public bool attacking = false;
	public PlatformerController Plat;
	public Motor Mot;
	public GameObject Right;
	public GameObject Left;
	public bool atkk;
	// Update is called once per frame
	void Update ()
	{
		if (attacking != true) {
			if (atkk) {
				if (Plat.direction) {
					Right.SetActive (true);
					attacking = true;
				} else if (Plat.direction == false) {
					Left.SetActive (true);
					attacking = true;
				}
			}
		} else if (attacking) {
			Mot.enabled = false;
			Plat.enabled = false;
			timer += Time.deltaTime;
			if (timer >= attacklength) {
				timer = 0;
				Right.SetActive (false);
				Left.SetActive (false);
				Plat.enabled = true;
				attacking = false;
				atkk = false;
				Mot.enabled = true;
			}
		}

		




	}


	public void Attack()
	{
		atkk = true;
	}
}
