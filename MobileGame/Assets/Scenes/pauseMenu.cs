using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

	public void swapControls()
	{
		GameObject Joystick = GameObject.Find ("BackgroundImage");
		GameObject Attack = GameObject.Find ("Attack");
		GameObject Jump = GameObject.Find ("Jump");
		Vector2 foo = Joystick.gameObject.GetComponent<RectTransform> ().anchoredPosition;
		Vector2 fooo = Attack.gameObject.GetComponent<RectTransform> ().anchoredPosition;
		Vector2 foooo = Jump.gameObject.GetComponent<RectTransform> ().anchoredPosition;
		Debug.Log (foo.x);
		if (foo.x == -1300) {
			foo = new Vector2 (0, foo.y);
			fooo = new Vector2 (150, fooo.y);
			foooo = new Vector2 (150, foooo.y);
		} else if (foo.x == 0) {
			foo = new Vector2 (-1300, foo.y);
			fooo = new Vector2 (1800, fooo.y);
			foooo = new Vector2 (1800, foooo.y);
		}
		Joystick.gameObject.GetComponent<RectTransform> ().anchoredPosition = foo;
		Attack.gameObject.GetComponent<RectTransform> ().anchoredPosition = fooo;
		Jump.gameObject.GetComponent<RectTransform> ().anchoredPosition = foooo;
	}

	 

	


}
