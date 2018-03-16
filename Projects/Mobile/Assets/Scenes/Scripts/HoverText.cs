using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoverText : MonoBehaviour {


    public bool Voted = false;

    private void OnMouseOver()
    {
        //Get<Transform>().localScale = new Vector3(1.2f, 1.2f, 1);
        GetComponent<TextMesh>().color = new Color(0, 0, 0.6f, 1);
    }

    private void OnMouseExit()
    {
        //GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        GetComponent<TextMesh>().color = new Color(0.8f, 0, 0, 1);
    }

    private void OnMouseDown()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Zet hier iets neer van Currentplayer +1 scorepoint ofzo :D
        GetComponent<TextMesh>().color = new Color(0, 0, 0.4f, 1);
        Voted = true;
    }
}
