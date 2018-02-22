using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {

	public AudioClip Aud;


	void OnTriggerEnter2D(Collider2D Coll)
	{
		int i = PlayerPrefs.GetInt ("Gems");
		i++;
		PlayerPrefs.SetInt("Gems",i);
		Coll.gameObject.GetComponent<AudioSource> ().PlayOneShot (Aud);
		Destroy (gameObject);

	}


}
