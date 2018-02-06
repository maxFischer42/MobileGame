using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

	public ParticleSystem Part;
	public bool active;
	float timer;
	public string Loadlevel;
	public GameObject aaa;
	// Update is called once per frame
	void Update () {
		if (active) {
			timer += Time.deltaTime;
			if (timer > 4) {
				SceneManager.LoadScene (Loadlevel);
				PlayerPrefs.SetString ("Level", Loadlevel);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.tag == "Player") {
			Part = GameObject.Find ("Particle System").GetComponent<ParticleSystem> ();
			Coll.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
			EndLevel ();
		}
	}

	void EndLevel()
	{
		Part.Play ();
		active = true;
	}


}
