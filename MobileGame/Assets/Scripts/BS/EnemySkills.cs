using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkills : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float HP(string Name)
	{
		switch (Name) {

		case "Slime":
			return 20;
			break;

		case "Theif":
			return 25;
			break;

		case "Skeleton":
			return 20;
			break;

		case "Guard":
			return 30;
			break;

		case "Spider":
			return 25;
			break;

		case "Mage":
			return 25;
			break;

		}
		return 0;

	}

	public float DEF(string Name)
	{
		switch (Name) {

		case "Slime":
			return 2;
			break;

		case "Theif":
			return 4;
			break;

		case "Skeleton":
			return 2;
			break;

		case "Guard":
			return 8;
			break;

		case "Spider":
			return 4;
			break;

		case "Mage":
			return 3;
			break;

		}
		return 0;
	}
}
