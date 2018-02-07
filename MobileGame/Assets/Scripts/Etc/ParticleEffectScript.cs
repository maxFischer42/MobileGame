using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectScript : MonoBehaviour {

	public bool active;
	public bool loading = false;
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
				if (loading != true) {
					timer = 0;
					active = false;
				}
			}
			if (timer > 7 && loading) {
				Destroy (gameObject, 2);
			}
		}
	}
}
