using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class ChangeServer : NetworkBehaviour {
    
    public GameObject[] spawnObjects;
    public GameObject spawnObject;

    public GameObject BeginScreen;

    public GameObject PlayerTest;

    public GameObject ServerTest;

    public GameObject Manager;

    [SyncVar]
    public int Round = 1;

	private bool YeaClicked = false;

    private bool Changer = false;


    void Update(){
        if(Changer){
            ChangeSceneNow();
            Changer = false;
        }
    }
    public void Change(int ToRound)
    {
        if (!isServer)
            return;
        
        Round = ToRound;
        Manager.GetComponent<ChangeEveryone>().ChangeSceneNow(Round);
        //PlayerObject.GetComponent<SetupLocalPlayer>().ChangeSceneNow(Round, BeginScreen, PlayerTest, ServerTest, spawnObject);
        Debug.Log("changedRound");
        Changer = true;
        
    }

    void ChangeSceneNow() {
        switch (Round)
        {
        case 5:
            print ("Going to round5");
            break;
        case 4:
            print ("Going to round4");
            break;
        case 3:
            print ("Going to round3");
            break;
        case 2:
            Instantiate(spawnObjects[0], new Vector2(10,0), Quaternion.identity);
            BeginScreen.SetActive(false);
            ServerTest.SetActive(true);
            print ("Going to Server Test");
            break;
        case 1:
            Debug.Log ("Going to Player Test");
            BeginScreen.SetActive(false);
            PlayerTest.SetActive(true);
            Instantiate(spawnObjects[1], new Vector2(10,0), Quaternion.identity);
            break;
        default:
            Debug.Log ("You did wrong boii");
            break;
        }
    }
}