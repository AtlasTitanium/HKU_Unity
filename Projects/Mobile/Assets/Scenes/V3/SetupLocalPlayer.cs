using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class SetupLocalPlayer : NetworkBehaviour {

	[SyncVar]
	public string pname = "player";

	public GameObject namea;
	private GameObject SettingsParent;

	private bool ChangeName = false;
	private bool ChangeCamera = false;

	private Text topname;
	private Camera playerCamera;

	[SyncVar]
	public Color playerColor = Color.white;

    public GameObject InvulHokje;
    public InputField SubmitText;

    [SyncVar]
    public Text PersonalHeadline;


    void Start(){
        InvulHokje = GameObject.FindWithTag("Invullen");
        InputField SubmitText = InvulHokje.GetComponent<InputField>();
    }

	void Update () {
		if (isLocalPlayer){
            PersonalHeadline = SubmitText.textComponent;
			if(ChangeName == true){
                if(topname == null){
                    topname = namea.GetComponent<Text>();
                } else {
                    topname.text = pname;
                    ChangeName = false;
                }
            }
			if(ChangeCamera == true){
                if(playerCamera == null){
                    playerCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
                } else {
                    playerCamera.clearFlags = CameraClearFlags.SolidColor;
					playerCamera.backgroundColor = playerColor;
                    ChangeCamera = false;
                }
            }
		}
	}
	public override void OnStartLocalPlayer()
    {
		SettingsParent = GameObject.FindWithTag("TopName");
		transform.parent = SettingsParent.transform;
		Debug.Log("new player entered the match");
        ChangeName = true;
		ChangeCamera = true;
    }
}
/*
private Text topname;

void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }


if(ChangeName == false){
                if(topname == null){
                    topname = GameObject.FindWithTag("TopName").GetComponent<Text>();
                } else {
                    topname.text = pname;
                    ChangeName = true;
                }
            }
*/