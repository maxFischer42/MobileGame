using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class communicatePlat : MonoBehaviour {

	public bool left;
	public bool ball;

	public MovePlatform Mov;

	public void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.name == "Feet") {
			if (ball != true) {
				switch (left) {
				case true:
					Mov.Left ();
					break;
				case false:
					Mov.Right ();
					break;
				}
			} else if (ball) {
				Mov.newBall ();
			}

		}
	}
}
