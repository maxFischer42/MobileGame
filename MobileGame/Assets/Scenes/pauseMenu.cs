using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public Canvas Pause;
	public bool isMainPause = true;

	public void toggleMenu()
	{
		Pause.enabled = !Pause.enabled;
		if (isMainPause) {
			if (Time.timeScale > 0) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
	}

	public void CloseGame()
	{
		Application.Quit ();
	}

	public void Menu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene ("Title");
	}



	 

	


}
