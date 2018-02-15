using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkCompletion : MonoBehaviour {

	public Button Med;
	public Button Hard;

	// Use this for initialization
	void Start () {
		int a = PlayerPrefs.GetInt ("diffUnlock");
		if (2 > a && a > 0) {
			Med.interactable = true;
		}
		if (a >= 2) {
			Hard.interactable = true;
		}
	}


}
