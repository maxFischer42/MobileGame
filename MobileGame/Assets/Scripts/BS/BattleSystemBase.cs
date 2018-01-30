using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystemBase : MonoBehaviour {

	public string[] skills =
	  { "Slash",
		"Counter",
		"Jab",
		"Block"};

	public int classMode, level;
	public Movement PlayMove;
	public Canvas HealthUI;
	public Canvas BattleUI;
	public Dropdown SkillBox;
	int turn = 1;
	public int currentTurn = 0;

	bool active = false;

	public GameObject[] enemies;
	private GameObject target;
	public int trgt = 0;
	public int targets = 1;

	public float[] animationTimer;

	public Animator FocusAnim;
	public float currentTimer;
	float timer;
	public CalcDamage CD;


	// Use this for initialization
	void Start ()
	{
		StartBattle ();
	}


	void animTimer(int skill)
	{
		timer += Time.deltaTime;
		if (timer >= currentTimer) {
			FocusAnim.runtimeAnimatorController = null;
			doDamage (skill);
			timer = 0;
		}
	}



	// Update is called once per frame
	void Update ()
	{if (active) {

			switch (currentTurn) {

			case 0:
				target = enemies [trgt];
				BattleUI.enabled = true;
				FocusAnim = enemies [0].gameObject.GetComponent<Animator> ();
				break;
			case 1:
				target = enemies [0];
				animTimer (getRandSkill(3));
				FocusAnim = enemies [1].gameObject.GetComponent<Animator> ();
				break;
			case 2:
				target = enemies [0];
				animTimer (getRandSkill(3));
				FocusAnim = enemies [2].gameObject.GetComponent<Animator> ();
				break;
			case 3:
				target = enemies [0];
				animTimer (getRandSkill(3));
				FocusAnim = enemies [3].gameObject.GetComponent<Animator> ();
				break;

			}




	}}







	public void StartBattle()
	{
		active = true;
		currentTurn = 0;
		PlayMove.enabled = false;
		BattleUI.enabled = true;
		SkillBox.options.Clear();
		AssignSkills (level);
	}


	public void SkillPress()
	{
		string selected = SkillBox.captionText.text;
		int skill = translateSkill (selected);
		Debug.Log (skill);
		BattleUI.enabled = false;
		FocusAnim.runtimeAnimatorController = PlayMove.attack;
		animTimer (skill);
	}


	public void doDamage(int skill)
	{
		target.GetComponent<statHolder> ().HP = CD.DamageCalculator (target.GetComponent<statHolder> ().HP,
			target.GetComponent<statHolder> ().DF, skill, enemies [0].gameObject.GetComponent<statHolder> ().HP,
			enemies [0].gameObject.GetComponent<statHolder> ().MHP);
		if (target.GetComponent<statHolder> ().HP >= 0){
			Destroy (target);
		}
		currentTurn++;
		if(currentTurn > turn){
			currentTurn = 0;
		}	

	}
		

	public void CalcTurn()
	{

	}


	public int getRandSkill(int max)
	{
		return Random.Range (0, max - 1);
	}


	public void AssignSkills(int lvl)
	{
		//add default skills
		for (int i = 0; i <= 3; i++) {
			SkillBox.options.Add (new Dropdown.OptionData (skills [i]));
		}
		switch (classMode) {
			case 0:
			MageSkills (lvl);
			break;

			case 1:
			KnightSkills (lvl);
			break;

			case 2:
			TheifSkills (lvl);
			break;
		}
	}



	void MageSkills(int lvl)
	{

			if(lvl >= 3){
				SkillBox.options.Add (new Dropdown.OptionData (skills [4]));
			}
			if(lvl >= 5){
				SkillBox.options.Add (new Dropdown.OptionData (skills [7]));
			}
			if(lvl >= 10){
				SkillBox.options.Add (new Dropdown.OptionData (skills [13]));
			}
			if(lvl >= 12){
				SkillBox.options.Add (new Dropdown.OptionData (skills [14]));
			}
			if(lvl >= 20){
				SkillBox.options.Add (new Dropdown.OptionData (skills [21]));
			}
	}


	void KnightSkills(int lvl)
	{

			if(lvl >= 4){
				SkillBox.options.Add (new Dropdown.OptionData (skills [6]));
			}
			if(lvl >= 8){
				SkillBox.options.Add (new Dropdown.OptionData (skills [9]));
				SkillBox.options.Add (new Dropdown.OptionData (skills [10]));
			}
			if(lvl >= 10){
				SkillBox.options.Add (new Dropdown.OptionData (skills [12]));
			}
			if(lvl >= 12){
				SkillBox.options.Add (new Dropdown.OptionData (skills [15]));
			}		
	}


	void TheifSkills(int lvl)
	{
		if(lvl >= 3){
				SkillBox.options.Add (new Dropdown.OptionData (skills [5]));
			}
			if(lvl >= 10){
				SkillBox.options.Add (new Dropdown.OptionData (skills [11]));
			}
			if(lvl >= 15){
				SkillBox.options.Add (new Dropdown.OptionData (skills [16]));
				SkillBox.options.Add (new Dropdown.OptionData (skills [17]));
				SkillBox.options.Add (new Dropdown.OptionData (skills [18]));
			}
		
	}


	int translateSkill(string skill)
	{
		switch (skill) {
		case "Slash":
			return 0;
			break;
		case "Counter":
			return 1;
			break;
		case "Jab":
			return 2;
			break;
		case "Block":
			return 3;
			break;
		case "Cast Heal":
			return 4;
			break;
		case "Theif":
			return 5;
			break;
		case "Spin Slash":
			return 6;
			break;
		case "Cast Fire":
			return 7;
			break;
		case "Cast Ice":
			return 8;
			break;
		case "Charge":
			return 9;
			break;
		case "Shield Bash":
			return 10;
			break;
		case "Hard Counter":
			return 11;
			break;
		case "Hard Slash":
			return 12;
			break;
		case "Cast Shield":
			return 13;
			break;
		case "Cast Light":
			return 14;
			break;
		case "Arrow Rain":
			return 15;
			break;
		case "Hide":
			return 16;
			break;
		case "Dash":
			return 17;
			break;
		case "Dart":
			return 18;
			break;
		case "Dragon's Scale":
			return 19;
			break;
		case "Dragon's Breath":
			return 20;
			break;
		case "Cast Dark":
			return 21;
			break;
		}
		return 0;
	}

}
