using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordSelector : MonoBehaviour {

    public TextAsset textFile;
    string[] wordPool;
    
    
    // Use this for initialization
	void Awake () {
        if (textFile != null)
        {
            wordPool = (textFile.text.Split('\n'));
            string randomWord = wordPool[Random.Range(0, wordPool.Length)];

            Text wordText = gameObject.GetComponent<Text>();
            wordText.text = randomWord;
        }
	}
	
}
