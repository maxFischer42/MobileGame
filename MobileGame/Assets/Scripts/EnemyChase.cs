using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]

public class EnemyMove : MonoBehaviour {

	public GameObject player;
	public float chaseSpeed = 2.0f;
	public float chaseTriggerDistance = 3.0f;
	private Vector3 startPosition;
	private bool home = true;
	public Vector3 paceDirection = new Vector3 (0f, 0f, 0f);
	public float paceDistance = 3.0f;
	// Use this for initialization
	void Start () {
		//get the spawn position so we know how to get home
		startPosition = transform.position;

	}

	// Update is called once per frame
	void Update () {
		Vector3 playerPosition = player.transform.position;
		Vector2 chaseDirection = new Vector2 (playerPosition.x - transform.position.x, 
			playerPosition.y - transform.position.y);
		if (chaseDirection.magnitude < chaseTriggerDistance) {
			//player gets too close to the enemy
			home = false;
			chaseDirection.Normalize ();
			GetComponent<Rigidbody2D> ().velocity = chaseDirection * chaseSpeed;
		} else if (home == false) {
			Vector2 homeDirection = new Vector2 (startPosition.x - transform.position.x,
				startPosition.y - transform.position.y);
			if (homeDirection.magnitude < 0.3f) {
				//we've arrived home
				home = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			} else {
				//go home
				homeDirection.Normalize ();
				GetComponent<Rigidbody2D> ().velocity = homeDirection * chaseSpeed;
			}
		} else {
			Vector3 displacement = transform.position - startPosition;
			float distanceFromStart = displacement.magnitude;
			if (distanceFromStart >= paceDistance) {
				//do stuff, we've gone too far
				paceDirection = -displacement;
			}
			paceDirection.Normalize ();
			GetComponent<Rigidbody2D> ().velocity = paceDirection * chaseSpeed;
		}
	}
}
