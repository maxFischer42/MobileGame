using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {

	public string levelToLoad;
	public int diff;

	public void press()
	{
		
		switch (diff) {
		case 0:
			PlayerPrefs.SetInt ("Difficulty",1);
			break;
		case 1:
			PlayerPrefs.SetInt ("Difficulty",2);
			break;
		case 2:
			PlayerPrefs.SetInt ("Difficulty",3);
			break;
		}
		PlayerPrefs.SetInt ("Deaths", 0);
		PlayerPrefs.SetInt ("Gems", 0);
		PlayerPrefs.SetInt ("Kills", 0);

		SceneManager.LoadScene (levelToLoad);
	}
	

}
