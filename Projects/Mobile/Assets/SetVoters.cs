using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVoters : MonoBehaviour {
	private int MaxVotes;
    private GameObject Voter1;
    private GameObject Voter2;
    private GameObject Voter3;
    private GameObject Voter4;
	// Use this for initialization
	void Start () {
		Debug.Log(PlayerPrefs.GetInt("MaxVotes").ToString());
		MaxVotes = PlayerPrefs.GetInt("MaxVotes");
		  //find and deactivate every voter
        GameObject Voter1 = GameObject.FindWithTag("Player1Vote");
        GameObject Voter2 = GameObject.FindWithTag("Player2Vote");
        GameObject Voter3 = GameObject.FindWithTag("Player3Vote");
        GameObject Voter4 = GameObject.FindWithTag("Player4Vote");
        Voter1.SetActive(false);
        Voter2.SetActive(false);
        Voter3.SetActive(false);
        Voter4.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Voter1 == null){GameObject Voter1 = GameObject.FindWithTag("Player1Vote");}
		if(Voter2 == null){GameObject Voter2 = GameObject.FindWithTag("Player2Vote");}
		if(Voter3 == null){GameObject Voter3 = GameObject.FindWithTag("Player3Vote");}
		if(Voter4 == null){GameObject Voter4 = GameObject.FindWithTag("Player4Vote");}
		Debug.Log(MaxVotes);
		Debug.Log(Voter1);
		//activate voter by players om scene
        if(MaxVotes == 1){Voter1.SetActive(true);}
        if(MaxVotes == 2){Voter2.SetActive(true);}
        if(MaxVotes == 3){Voter3.SetActive(true);}
        if(MaxVotes == 4){Voter4.SetActive(true);}
	}
}
