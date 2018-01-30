using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcDamage : MonoBehaviour
{
	public float[] damage;
	public float[] accuracy;
	public float[] luck;
	public float[] mp;

	public int skillUsed;

	public float enemyHP;
	public float enemyDF;
	public float playerHP;
	public float playerMHP;

	public float DamageCalculator(float HP, float DF, int usedAttack, float PHP, float PMHP)
	{
		skillUsed = usedAttack;

		float DMG = damage [skillUsed];

		if (skillUsed != 4 ||
		    skillUsed != 5 ||
		    skillUsed != 11 ||
		    skillUsed != 12) {
			float dg = damage [skillUsed];
			float acc = accuracy [skillUsed];
			float lk = luck [skillUsed];

			float dmgdone = DMG;
			float randomNum;
			randomNum = Random.Range (0, 100);
			if (randomNum <= lk) {
				//crit
				dmgdone += DMG * 1.5f;
			}
			randomNum = Random.Range (0, 100);
			if (randomNum > acc) {
				//miss
				dmgdone *= 0;
			}

			if (dmgdone != 0) {
				dmgdone += dg;
				dmgdone -= DF;
			}
			Debug.Log ("used skill " + skillUsed + " as " + gameObject.GetComponent<BattleSystemBase> ().enemies [gameObject.GetComponent<BattleSystemBase> ().currentTurn].gameObject.name);
			return HP -= dmgdone;
		} else {
			PHP += DMG;
			if (PHP > PMHP)
				PHP = PMHP - PHP;
		}
		return 0f;
	}
		
}
