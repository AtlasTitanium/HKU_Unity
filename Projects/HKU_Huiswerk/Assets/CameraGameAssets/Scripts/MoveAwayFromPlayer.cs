using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAwayFromPlayer : MonoBehaviour {

	public GameObject Ghost;
	public Transform target;
	public Transform origin;
     public float speed = 5f;
     public float minDistance = 3f;
     private float range;
	 private float hight = 2f;
	 public float floatspeed;
	 private bool tag = true;

	void Start(){
		origin.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
	}
     void Update()
     {
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

         range = Vector3.Distance(transform.position, target.position);

		if (range > minDistance)
		{
			transform.position = Vector3.MoveTowards(transform.position, origin.position, 1 * speed * Time.deltaTime);
		}
	
		if (range < minDistance)
		{
			transform.position = Vector3.MoveTowards(transform.position, target.position, -1 * speed * Time.deltaTime);
		}
     }
}
