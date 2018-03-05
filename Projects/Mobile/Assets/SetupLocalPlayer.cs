using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class SetupLocalPlayer : NetworkBehaviour {

	[SyncVar]
	public string pname = "player";

	private Text topname;

	private bool tag;

	[SyncVar]
	public Color playerColor = Color.white;

	[Command]
	public void CmdChangeName(string newName){
		pname = newName;
		this.GetComponentInChildren<TextMesh>().text = pname;
	}
	// Use this for initialization
	void Start () {
		if(isLocalPlayer){
			this.GetComponent<SpriteRenderer>().color = playerColor;
		}
		this.transform.position = new Vector2(Random.Range(-20,20),Random.Range(-20,20));
	}
	
	// Update is called once per frame
	void Update () {
		if(tag == false){
                if(topname == null){
                    topname = GameObject.FindWithTag("TopName").GetComponent<Text>();
                } else {
                    topname.text = pname;
                    tag = true;
                }
            }
	}
}
