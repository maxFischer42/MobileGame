using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketPuzzle : MonoBehaviour {

	public Rigidbody2D Box;


	public void Up(float multiplier)
	{
		Box.AddForce (new Vector2 (0, multiplier));
	}

	public void Down(float multiplier)
	{
		Box.AddForce (new Vector2 (0, multiplier * -1));
	}

	public void Left(float multiplier)
	{
		Box.AddForce (new Vector2 (multiplier * -1,0));
	}

	public void Right(float multiplier)
	{
		Box.AddForce (new Vector2 (multiplier,0));
	}
}
