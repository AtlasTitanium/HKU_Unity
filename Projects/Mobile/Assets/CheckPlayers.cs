using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayers : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Player(Clone)") != null) {
             Debug.Log ("get one");
			 Debug.Log (GameObject.Find ("Player(Clone)"));
         } else {
             Debug.Log ("not there");
         }
	}
}
