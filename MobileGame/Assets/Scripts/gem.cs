using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Coll)
	{
		Destroy (gameObject, 0.2f);
		int i = PlayerPrefs.GetInt ("Gems");
		i++;
		PlayerPrefs.SetInt("Gems",i);
	}


}
