using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthHandler : MonoBehaviour {

	public int mHP = 8;
	public int hP;
	public Image[] Containers;
	public Sprite[] Hearts;



	// Use this for initialization
	void Start ()
	{
		hP = mHP;
		PlayerPrefs.SetInt ("HP", mHP);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Hurt> ().HP = hP;
		switch (hP) {
		case 8:
			Containers [0].sprite = Hearts [0];
			Containers [1].sprite = Hearts [0];
			break;
		case 7:
			Containers [0].sprite = Hearts [1];
			Containers [1].sprite = Hearts [0];
			break;
		case 6:
			Containers [0].sprite = Hearts [2];
			Containers [1].sprite = Hearts [0];
			break;
		case 5:
			Containers [0].sprite = Hearts [3];
			Containers [1].sprite = Hearts [0];
			break;
		case 4:
			Containers [0].sprite = Hearts [4];
			Containers [1].sprite = Hearts [0];
			break;
		case 3:
			Containers [0].sprite = Hearts [4];
			Containers [1].sprite = Hearts [1];
			break;
		case 2:
			Containers [0].sprite = Hearts [4];
			Containers [1].sprite = Hearts [2];
			break;
		case 1:
			Containers [0].sprite = Hearts [4];
			Containers [1].sprite = Hearts [3];
			break;
		}
	}
}
