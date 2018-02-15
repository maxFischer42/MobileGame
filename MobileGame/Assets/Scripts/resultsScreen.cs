using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultsScreen : MonoBehaviour {

	public int gemAmount;
	public int deathCounter;
	public int killCounter;
	public ParticleSystem part;
	private float timer = 0f;
	public float timeAmount;
	public float timeUntilPartStart;
	public float timeUntilResultDisplay;
	bool partStart;
	bool resultDisplay;
	public Canvas statDisplay;
	public Text[] stats;
	int scoreTotal;

	// Use this for initialization
	void Start ()
	{
		gemAmount = PlayerPrefs.GetInt ("Gems");
		deathCounter = PlayerPrefs.GetInt ("Deaths");
		killCounter = PlayerPrefs.GetInt ("Kills");

		if (gemAmount > 9 && PlayerPrefs.GetInt ("Difficulty") == 0) {
			PlayerPrefs.SetInt ("Difficulty", 1);
		}
		if (gemAmount > 16 && PlayerPrefs.GetInt ("Difficulty") == 1) {
			PlayerPrefs.SetInt ("Difficulty", 2);
		}


		scoreTotal = calcScore (gemAmount, killCounter, deathCounter);

		for (int i = 0; i < stats.Length; i++) {
			AssignText (stats [i], i);
		}

		var main = part.main;
		main.maxParticles = gemAmount;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > timeUntilPartStart && partStart != true)
		{
			partStart = true;
			part.Play ();
		}
		if (timer > 4.0f && resultDisplay != true) {
			timer = part.time;
			resultDisplay = true;
			statDisplay.enabled = true;
		}
	}

	void AssignText(Text text, int index)
	{
		switch (index) {
		case 0:
			text.text = "Gems Collected : " + gemAmount;
			break;
		case 1:
			text.text = "Deaths : " + deathCounter;
			break;
		case 2:
			text.text = "Slimes that fell to your blade : " + killCounter;
			break;
		case 3:
			text.text = "" + scoreTotal;
			break;


		}


	}

	int calcScore(int gems, int kills, int deaths)
	{
		int difficultyMultiplier = 0;

		switch(PlayerPrefs.GetInt("Difficulty")){
		case 1:
			difficultyMultiplier = 1;
			break;
		case 2:
			difficultyMultiplier = 2;
			break;
		case 3:
			difficultyMultiplier = 5;
			break;
		}

		int gemWorth = gems;
		gemWorth *= difficultyMultiplier;

		int killWorth = kills;
		killWorth *= difficultyMultiplier;

		int deathWorth = deaths;
		deathWorth *= difficultyMultiplier * 2;

		int score = 0;
		score += gemWorth;
		score += killWorth;
		score -= deathWorth;
		Debug.Log (score);

		return score;
	}

}
