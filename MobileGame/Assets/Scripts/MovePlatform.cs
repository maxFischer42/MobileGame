using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

	public GameObject currentBall;
	public Rigidbody2D Platform;
	public float multiplierX;
	public float multiplierY;
	public GameObject BallSpawn;
	public GameObject ballPrefab;
	public Vector2 spawnDirection;



	public void Left(){
		Platform.velocity = (new Vector2(-1 * multiplierX, -1 * multiplierY));
			}

	public void Right(){
		Platform.velocity = (new Vector2(multiplierX, multiplierY));
	}

	public void newBall()
	{
		Destroy (currentBall);
		GameObject newBall;
		newBall = ballPrefab;
		newBall.GetComponent<Rigidbody2D> ().AddForce (spawnDirection);
		GameObject.Instantiate (newBall, BallSpawn.transform);
	
	}
}
