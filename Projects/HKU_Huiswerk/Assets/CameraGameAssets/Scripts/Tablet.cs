using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour {
    public GameObject tablet;
	bool flag = true;
 
 	void Update () {
     	if(Input.GetKeyDown(KeyCode.Tab)){
			flag = !flag; //set flag to opposite value
			Debug.Log("flag is " + flag);
			changer();
     	}
 	}
	
	void changer(){
		if(flag){       
         	tablet.SetActive(true);
			Debug.Log("tablet is " + tablet.activeSelf);
			tablet.GetComponent<Animation>().Play();
     	} else {
         	tablet.SetActive(false);
			Debug.Log("tablet is " + tablet.activeSelf);
			tablet.GetComponent<Animation>().Play();
     	}
	}
}
