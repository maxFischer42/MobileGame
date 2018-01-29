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

	public Movement PlayMove;


	public Canvas HealthUI;
	public Canvas BattleUI;
	public Dropdown SkillBox;
	int[] turn;
	int currentTurn = 0;

	bool active = false;
	bool chosen = false;

	private GameObject[] enemies;
	private GameObject target;




	// Use this for initialization
	void Start ()
	{
		StartBattle ();
	}




	// Update is called once per frame
	void Update ()
	{if (active) {

			switch (currentTurn) {

			case 0:
				if (chosen) {
					currentTurn++;
				}
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
		AssignSkills ();
	}






	public void CalcTurn()
	{

	}



	public void AssignSkills()
	{
		for (int i = 0; i < skills.Length; i++) {
			SkillBox.options.Add (new Dropdown.OptionData (skills [i]));
		}
	}



}
