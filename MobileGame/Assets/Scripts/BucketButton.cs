using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketButton : MonoBehaviour {
	public BucketPuzzle Buck;
	public float multiplier = 2.0;
	public int direction;
	public Sprite Disabled;
	public Sprite Enabled;
	//0 = up 1 = down
	//2 = left 3 = right

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.name == "Feet") {
			switch (direction) {
			case 0:
				Buck.Up (multiplier);
				break;
			case 1:
				Buck.Down (multiplier);
				break;
			case 2:
				Buck.Left (multiplier);
				break;
			case 3:
				Buck.Right (multiplier);
				break;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.name == "Feet") {
			switch (direction) {
			case 0:
				Buck.Up (multiplier);
				break;
			case 1:
				Buck.Down (multiplier);
				break;
			case 2:
				Buck.Left (multiplier);
				break;
			case 3:
				Buck.Right (multiplier);
				break;
			}
		}
	}



}
