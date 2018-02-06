using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceRocks : MonoBehaviour
{
	public Vector2 start;
	public Vector2 end;
	public GameObject Rock;

	// Use this for initialization
	void Start ()
	{
		Rocks newRocks = new Rocks ();
		newRocks.startPos = start;
		newRocks.endPos = end;
		newRocks.Prefab = Rock;

		float ys = newRocks.startPos.y;
		float xs = newRocks.startPos.x;

		float ye = newRocks.endPos.y;
		float xe = newRocks.endPos.x;

		for (float i = ys; i <= ye; i++)
		{
			for (float a = xs; a <= xe; a++) {
				newRocks.place (a, i);
			}
		}


	}
	




}

public class Rocks
{
	public Vector2 startPos;
	public Vector2 endPos;
	public GameObject Prefab;

	public void place(float x,float y)
	{
		GameObject.Instantiate (Prefab, new Vector3 (x, y, 0), Quaternion.identity);
	}

}


