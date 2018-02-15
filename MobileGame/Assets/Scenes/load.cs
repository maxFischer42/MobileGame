using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {

	public string levelToLoad;
	public int diff;

	public void press()
	{
		SceneManager.LoadScene (levelToLoad);
		switch (diff) {
		case 0:
			PlayerPrefs.SetInt ("Difficulty") = 1;
			break;

		}
	}
	

}
