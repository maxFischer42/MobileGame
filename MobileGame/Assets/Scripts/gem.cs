using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Coll)
	{
		int i = PlayerPrefs.GetInt ("Gems");
		i++;
		PlayerPrefs.SetInt("Gems",i);
		Destroy (gameObject);

	}


}
