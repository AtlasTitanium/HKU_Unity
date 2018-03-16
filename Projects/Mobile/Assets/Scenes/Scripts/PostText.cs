using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostText : MonoBehaviour {

    public Text userInput;
    public Text word1;
    public Text word2;
    public Text word3;

    void Start () {
        Button postButton = gameObject.GetComponent<Button>();
        postButton.onClick.AddListener(TaskOnClick);
    }
	
	void TaskOnClick () {
        if (userInput.text.Equals("INVULLEN") || userInput.text.Equals("")) { }
        //ignore commented bit prolly better off without it - Wes
        else /*if (userInput.text.Contains(word1.text))*/
        {
            SceneManager.LoadScene("VotingRound");
        }
	}
}
