using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour {
    public GameObject tablet;
	public GameObject Camera;
	bool flag = true;
	bool fleg = true;
 
 	void Update () {
     	if(Input.GetKeyDown(KeyCode.Tab)){
			flag = !flag; //set flag to opposite value
			Debug.Log("flag is " + flag);
			changer();
     	}
		if(Input.GetKeyDown(KeyCode.Q)){
			fleg = !fleg; //set flag to opposite value
			Debug.Log("fleg is " + fleg);
			changer2();
     	}
 	}
	
	void changer(){
		if(flag){       
         	tablet.SetActive(true);
			Debug.Log("tablet is " + tablet.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	} else {
         	tablet.SetActive(false);
			Debug.Log("tablet is " + tablet.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	}
	} 
	void changer2(){
		if(fleg){       
         	Camera.SetActive(true);
			Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	} else {
         	Camera.SetActive(false);
			Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	}
	}
}
