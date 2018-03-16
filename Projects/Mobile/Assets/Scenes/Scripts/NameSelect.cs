using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class NameSelect : NetworkBehaviour {
    public string playerName = "player1";

    public InputField Name;

    void Start(){
        playerName = "Name" + Random.Range (0,999);
    }

    void Update(){
        playerName = Name.text;
    }
}  