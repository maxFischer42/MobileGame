using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectScript : MonoBehaviour {

	public bool active;
	float timer;


	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update ()
	{
		active = GetComponent<ParticleSystem> ().isPlaying;
		if (active) {
			timer += Time.deltaTime;
			if (timer > 4) {
				transform.SetPositionAndRotation (GameObject.Find ("Player").gameObject.transform.position, Quaternion.identity);
				GetComponent<ParticleSystem> ().Stop ();
			}
			if (timer > 7) {
				Destroy (gameObject, 2);
			}
		}
	}
}
