using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

	public Vector2 Spawn;
	Rigidbody2D Rig;
	public ParticleSystem Part;
	public Transform par;
	bool active = false;
	float timer;
	public AudioClip Dead;

	void Update()
	{
		if (active) {
			Debug.Log (timer);
			timer += Time.deltaTime;

			if (timer > 3) {
				Rig.bodyType = RigidbodyType2D.Dynamic;
				par.SetPositionAndRotation (Spawn, Quaternion.identity);
				active = false;

				Part.Stop ();
				timer = 0;

			}
		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			kill ();
		}
	}

	public void kill()
	{
			GameObject Coll = GameObject.Find ("Player");
			Part = GameObject.Find ("Particle System").GetComponent<ParticleSystem> ();
			par = Coll.gameObject.transform;
			Rig = Coll.gameObject.GetComponent<Rigidbody2D> ();
			Rig.bodyType = RigidbodyType2D.Static;
			active = true;
			Coll.GetComponent<PlayerHealthHandler> ().hP = Coll.GetComponent<PlayerHealthHandler> ().mHP;
			int i = PlayerPrefs.GetInt ("Deaths");
			i++;
			PlayerPrefs.SetInt ("Deaths", i);
			Coll.GetComponent<AudioSource> ().PlayOneShot (Dead);
			Part.Play ();
	}


}
