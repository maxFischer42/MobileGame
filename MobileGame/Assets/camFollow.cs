using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {
		Vector3 camera = new Vector3(player.position.x, player.position.y, transform.position.z);
		transform.SetPositionAndRotation (camera, Quaternion.identity);
	}
}
