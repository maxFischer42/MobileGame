using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBattle : MonoBehaviour {

	public BattleSystemBase BS;

	void OnTriggerEnter2D(Collider2D Coll)
	{
		BS.StartBattle ();
	}



}
