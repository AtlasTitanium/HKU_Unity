using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIdelete : MonoBehaviour {
	public Image nav;
	public Image Bone;
	public Image Btwo;
	public Image Return;
	public float Spedo;
	public void navStart(){
	if(!nav.gameObject.active){
		nav.gameObject.SetActive(true);
		StartCoroutine(StartSlide(Spedo));
	} else if(nav.gameObject.active){
		nav.gameObject.SetActive(true);
		StartCoroutine(StartSlide(-Spedo));
	}
	}

	IEnumerator StartSlide(float i){
		yield return new WaitForSeconds(0.01f);
		nav.fillAmount = nav.fillAmount + (i / 2);
		Bone.fillAmount = Bone.fillAmount + i;
		Btwo.fillAmount = Btwo.fillAmount + i;
		Return.fillAmount = Return.fillAmount + i;
		if(nav.fillAmount<0.55f && nav.fillAmount>0){
			StartCoroutine(StartSlide(i));
		} else if(nav.fillAmount==0){
			nav.gameObject.SetActive(false);
		}
	}
}
