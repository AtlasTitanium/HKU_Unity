using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayFromPlayer : MonoBehaviour {
	public Transform[] Ghostmaterials;
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

	void Start(){
		thisScript = this;
		origin.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		newyposition = transform.position.y;
	}
     void Update()
     {
		Ghostmaterials[0] = transform.GetChild(2).transform.GetChild(0);
		Ghostmaterials[1] = transform.GetChild(2).transform.GetChild(1);
		Ghostmaterials[2] = transform.GetChild(2).transform.GetChild(2);
		Ghostmaterials[3] = transform.GetChild(2).transform.GetChild(3);
		if(TAGO){
			Debug.Log(GhostisWhining);
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
				Debug.Log("Ghost should change");
			}
		} else{ 
			Debug.Log("Ghost should not run away");
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
		for(int i = 0; i < Ghostmaterials.Length; i++){
			Ghostmaterials[i].gameObject.GetComponent<Renderer>().material = lovelymaterial;
			Ghostmaterials[i].gameObject.layer = 0;
		}
	}

	public void Objecthasbeenpickedup(){
		TAGO = false;
	}
}
