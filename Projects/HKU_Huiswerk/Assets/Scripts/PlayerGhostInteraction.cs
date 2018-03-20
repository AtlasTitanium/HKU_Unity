using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhostInteraction : MonoBehaviour {
	public GameObject TheGhost;
	public GameObject TheGhostwords;
	private WhatSaisGhost TheGhostwordsscript;
	public GameObject PickupObject;
	public GameObject ThePlayer;
	private PickupPickup ThePlayerScript;

	public bool gotobject = false;

	// Use this for initialization
	void Start () {
		gotobject = false;
		ThePlayerScript = ThePlayer.GetComponent<PickupPickup>();
		TheGhost.GetComponent<MoveAwayFromPlayer>().enabled = true;
		TheGhostwordsscript = TheGhostwords.GetComponent<WhatSaisGhost>();
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i < ThePlayerScript.Inventory.Length; i++){
			if(ThePlayerScript.Inventory[i] == PickupObject){
				gotobject = true;
				TheGhost.GetComponent<MoveAwayFromPlayer>().Hover();
				TheGhost.GetComponent<MoveAwayFromPlayer>().Objecthasbeenpickedup();
				//Debug.Log("Player has the object");
			} else {
				gotobject = false;
				TheGhost.GetComponent<MoveAwayFromPlayer>().enabled = true;
				TheGhostwords.GetComponent<WhatSaisGhost>().enabled = true;
				//Debug.Log("Player doesn't have the object");
			}
		}
	}

	public void RemoveGhost(){
		TheGhostwordsscript.TheText.text = "";
		TheGhost.GetComponent<MoveAwayFromPlayer>().GhostGoesAway();
		TheGhostwords.GetComponent<WhatSaisGhost>().GhostGoesAway();
	}
}
