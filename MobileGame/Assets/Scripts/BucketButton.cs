using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketButton : MonoBehaviour {
	public BucketPuzzle Buck;
	public float multiplier = 2.0f;
	public int direction;
	public BoxCollider2D Box;
	public bool offsetting;
	public Transform trans;
	public Vector2 Origin;

	//0 = up 1 = down
	//2 = left 3 = right

	void Start()
	{
		Origin = trans.position;
	}


	void Update()
	{
		if (offsetting) {
			trans.SetPositionAndRotation(Origin, Quaternion.identity);
			trans.SetPositionAndRotation (new Vector2 (Origin.x, Origin.y - 0.5f), Quaternion.identity);



		} else {
			Box.offset = new Vector2(0, 0);
			trans.SetPositionAndRotation(Origin,Quaternion.identity);
		}
	}


	void OnTriggerEnter2D(Collider2D Coll)
	{
		offsetting = true;
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

	void OnTriggerStay2D(Collider2D Coll)
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

	void OnTriggerExit2D(Collider2D Coll)
	{
		offsetting = false;

	}


}
