using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayFromPlayer : MonoBehaviour {
	 public static MoveAwayFromPlayer thisScript;
	
	public Material lovelymaterial;
	public GameObject Ghost;
	public Transform target;
	public Transform origin;
     public float speed = 5f;
     public float minDistance = 3f;
     private float range;
	 private float hight = 2f;
	 public float floatspeed;
	 private bool tag = true;

	 private bool GhostisWhining = true;

	 private float newyposition;
	 private float Transperancy = 1f;

	 private bool TAGO = true;

	 public GameObject nextGhost;

	void Start(){
		thisScript = this;
		origin.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		newyposition = transform.position.y;
	}
     void Update()
     {
		if(TAGO){
			//Debug.Log(GhostisWhining);
			if(GhostisWhining){
				Hover();
				range = Vector3.Distance(transform.position, target.position);

				if (range > minDistance)
				{
					transform.position = Vector3.MoveTowards(transform.position, origin.position, 1 * speed * Time.deltaTime);
				}
			
				if (range < minDistance)
				{
					transform.position = Vector3.MoveTowards(transform.position, target.position, -1 * speed * Time.deltaTime);
				}

				newyposition = transform.position.y;
			} else {
				//Debug.Log("Ghost should change");
			}
		}
    }

	public void Hover(){
		Ghost.transform.position = new Vector3(transform.position.x,hight,transform.position.z);
		if(hight < 1.5f){
			tag = true;
		}

		if(hight > 3f){
			tag = false;
		}

		if(tag){
			hight += floatspeed*Time.deltaTime;
		} else {
			hight -= floatspeed*Time.deltaTime;
		}
		newyposition = transform.position.y;
	}

	public void GhostGoesAway(){
		TAGO = true;
		GhostisWhining = false;
		gameObject.GetComponent<Renderer>().material = lovelymaterial;
		gameObject.layer = 0;
		nextGhost.layer = 10;
		nextGhost.tag = "PickupObject";
		nextGhost.SetActive(true);
	}

	public void Objecthasbeenpickedup(){
		TAGO = false;
	}
}
