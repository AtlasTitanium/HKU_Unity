using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class SetupLocalPlayer : NetworkBehaviour {

	[SyncVar]
	public string pname = "player";

	private Text topname;

	private bool tag = true;


	[SyncVar]
	public Color playerColor = Color.white;

	void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	void Start () {
		if (isLocalPlayer){
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponentInChildren<Camera>().clearFlags = CameraClearFlags.SolidColor;
			GetComponentInChildren<Camera>().backgroundColor = playerColor;
		}
		this.transform.position = new Vector2(0,0);
	}
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
	public override void OnStartLocalPlayer()
    {
        tag = false;
    }
}
