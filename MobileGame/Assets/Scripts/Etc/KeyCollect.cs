using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour {

	public AudioClip Aud;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			PlayerPrefs.SetInt ("Key", 1);
			Coll.GetComponent<AudioSource> ().PlayOneShot (Aud);
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			PlayerPrefs.SetInt ("Key", 1);
			Coll.gameObject.GetComponent<AudioSource> ().PlayOneShot (Aud);
			Destroy (gameObject);
		}
	}
}
