using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour {

	public bool isPlayer = false;
	public float timeUntilDestroy = 1f;
	public string weakness;
	public int HP;
	float timer = 0;
	bool invinsible = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (isPlayer != true && HP <= 0) {
			Destroy (gameObject, timeUntilDestroy);
		}
		if (invinsible && timer > 1f) {
			timer = 0;
			invinsible = false;
		}
	}

	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == weakness&& invinsible != true) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2 (Random.Range(-10,10),Random.Range(-10,10)));
			invinsible = true;
			switch (isPlayer) {
			case true:
				gameObject.GetComponent<PlayerHealthHandler> ().hP -= 1;
				break;
			case false:
				HP -= 1;
				break;
			}
		}
	}



	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == weakness && invinsible != true) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2 (Random.Range(-10,10),Random.Range(-10,10)));
			invinsible = true;
			switch (isPlayer) {
			case true:
				gameObject.GetComponent<PlayerHealthHandler> ().hP -= 1;
				break;
			case false:
				HP -= 1;
				break;
			}
		}
	}
}
