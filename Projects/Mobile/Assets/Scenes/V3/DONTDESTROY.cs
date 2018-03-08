using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTROY : MonoBehaviour {
	// Update is called once per frame
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
}
