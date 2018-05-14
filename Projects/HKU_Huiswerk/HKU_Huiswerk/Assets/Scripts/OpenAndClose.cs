using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndClose : MonoBehaviour {
	public GameObject ThePlayer;
	public Collider triggerOpen;
	public Collider triggerClose;

	public Animator animatorLeftDoor;
	public Animator animatorRightDoor;

	public Animator animatorLeftDoornowere;
	public Animator animatorRightDoornowere;
	// Use this for initialization
	void Start () {
		//animatorLeftDoor = GetComponent<Animator>();
		//animatorRightDoor = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if(other == triggerClose){
			ThePlayer.GetComponent<Tablet>().enabled = true;
			animatorLeftDoor.Play("DoorClose");
			animatorRightDoor.Play("DoorClose2");
			animatorLeftDoornowere.Play("DoorClose");
			animatorRightDoornowere.Play("DoorClose2");
		}

		if(other == triggerOpen){
			animatorLeftDoor.Play("DoorOpen");
			animatorRightDoor.Play("DoorOpen2");
			animatorLeftDoornowere.Play("DoorOpen");
			animatorRightDoornowere.Play("DoorOpen2");
		}
	}
}
