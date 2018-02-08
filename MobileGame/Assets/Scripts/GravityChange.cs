using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour {

	public GameObject Feet;
	public GameObject AboveFeet;

		void OnTriggerEnter2D(Collider2D Coll)
	{
		if (Coll.gameObject.layer == 10) {
			GetComponent<Rigidbody2D> ().gravityScale = (Mathf.Abs (GetComponent<Rigidbody2D> ().gravityScale)) * -1;
			Feet.SetActive (false);
			AboveFeet.SetActive (true);
				

			/*} else if(Coll.gameObject.tag == "Bucket"){
			Debug.Log ("Boosted");
			Rigidbody2D Rig = Coll.GetComponent<Rigidbody2D> ();
			Rig.AddForce (new Vector2(0, 350));

		*/
		}
	}

	void OnTriggerExit2D(Collider2D Coll){
	//	if (Coll.gameObject.tag != "Bucket" && Coll.gameObject.layer != 8) {
		if (Coll.gameObject.layer == 10) {
			GetComponent<Rigidbody2D> ().gravityScale = 3;
			Feet.SetActive (true);
			AboveFeet.SetActive (false);
		//}
		}
	}

}
