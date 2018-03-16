using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public string userHeadline;
    public Text word1;
    public Text word2;
    public Text word3;

    void Update()
    {


        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        //if in FillRound get user input
        if (currentScene.name == "FillRound")
        {
            string UserInput = GameObject.Find("invullen text").GetComponent<Text>().text;
            userHeadline = UserInput.ToString();
        }

        //if in VotingRound take user input and show it
        if (currentScene.name == "VotingRound")
        {
            Debug.Log('j');
            GameObject.Find("Vote1").GetComponent<TextMesh>().text = "<color=black>" + userHeadline + "</color>";
        }
    }
}
