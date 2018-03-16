using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour {
    public GameObject tablet;
	public GameObject Camera;

	public Animator Tabletanim;

	public Animator Cameraanim;
	bool flag = true;
	bool fleg = true;
	
 	void Update () {
     	if(Input.GetKeyDown(KeyCode.Tab)){
			if(fleg){
			flag = !flag; //set flag to opposite value
			Debug.Log("flag is " + flag);
			changer();
			}
     	}
		if(Input.GetKeyDown(KeyCode.Q)){
			if(flag){
			fleg = !fleg; //set flag to opposite value
			Debug.Log("fleg is " + fleg);
			changer2();
			}
     	}
 	}
	
	void changer(){
		if(flag){       
         	Tabletanim.SetTrigger("ClickTab");
			Debug.Log("tablet is " + tablet.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	} else {
         	Tabletanim.SetTrigger("ClickTab");
			Debug.Log("tablet is " + tablet.activeSelf);
			//tablet.GetComponent<Animation>().Play();
     	}
	} 
	void changer2(){
		if(fleg){       
			Cameraanim.SetTrigger("Clickq");
			Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	} else {
			Cameraanim.SetTrigger("Clickq");
			Debug.Log("Camera is " + Camera.activeSelf);
			//Camera.GetComponent<Animation>().Play();
     	}
	}
}
