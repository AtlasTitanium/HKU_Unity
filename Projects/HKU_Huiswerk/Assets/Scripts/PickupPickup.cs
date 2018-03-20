using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPickup : MonoBehaviour {
	public GameObject[] Inventory;

	public GameObject[] Pickups;

	public GameObject fpsCam;
	public GameObject Ghosts;
	private PlayerGhostInteraction GhostsScript;

	public float range;

	void Start () {
		GhostsScript = Ghosts.GetComponent<PlayerGhostInteraction>();
		Pickups = GameObject.FindGameObjectsWithTag("PickupObject");
		Inventory = GameObject.FindGameObjectsWithTag("PickupObject");
		for(int i = 0; i < Inventory.Length; i++){
			Inventory[i] = null;
		}
		//Debug.Log("There are " + Pickups.Length + " pickups in this scene");
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(1)){
			DOINGIT();
		}
		/*
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit)){
			if(hit.collider == Pickups[Pickups.Length-1]){
				Debug.Log("you're looking at the pickup object");
			}
			print("There is something in front of the object!");
		}
		*/
	}

	public void DOINGIT() {
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range/2, 1 << LayerMask.NameToLayer("Pickups"))){
			//Debug.Log(hit.transform.name);
			if(hit.transform == Pickups[0].transform){
				Inventory[0] = Pickups[0];
				Pickups[0].SetActive(false);
				Pickups[0] = null;
			}
		}

		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range, 1 << LayerMask.NameToLayer("Invisible"))){
			if(GhostsScript.gotobject){
				//Debug.Log(hit.transform.name);
				GhostsScript.RemoveGhost();
			}
			//if(hit.transform == Pickups[0].transform){}
		}
	}
}
