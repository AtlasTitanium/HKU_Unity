using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatSaisGhost : MonoBehaviour {
	private TextMesh TheText;
	public Transform plauyer;
	public Transform parent;
	public Material rend;
	public string[] WhatDoesTheGhostSay;
	private float xposition;
	private float yposition;
	private float originxposition;
	private float originyposition;
	private float originzposition;
	private float transparensy;
	private bool isactive = true;
	private float speed = 0.01f;
	private bool changetransperancy  = false;
	private int randomnummer;
	
	void Start () {
		Material rend = gameObject.GetComponent<Material>();
		TheText = gameObject.GetComponent<TextMesh>();
		TheText.text = "";
		xposition = gameObject.transform.position.x;
		yposition = gameObject.transform.position.y;
		originyposition = gameObject.transform.position.y;
		randomnummer = Random.Range(0,WhatDoesTheGhostSay.Length);
	}
	
	void Update () {
		originxposition = parent.position.x;
		originzposition = parent.position.z;
		if(isactive){
			TheText.text = WhatDoesTheGhostSay[randomnummer];
			xposition += speed;
			yposition += speed/2;
			if(changetransperancy){
				transparensy -= speed;
			} else {
				transparensy += speed;
			}
			if(transparensy > 0.9f){changetransperancy = true;}
			gameObject.transform.position = new Vector3(xposition,yposition,originzposition);
        	rend.color = new Color(0,0,0,transparensy);
			if(transparensy < 0f){
				isactive = false;
			}
		} else {
			TheText.text = "";
			randomnummer = Random.Range(0,WhatDoesTheGhostSay.Length);
			transparensy = 0.1f;
			xposition = originxposition;
			yposition = originyposition;
			StartCoroutine(WaitThisLong(2));
		}
		Vector3 target = new Vector3(plauyer.position.x, transform.position.y, plauyer.position.z);
		transform.LookAt(target);
	}

	IEnumerator WaitThisLong(int timewasted){
        yield return new WaitForSeconds(timewasted);
		changetransperancy = false;
		isactive = true;
	}
}
