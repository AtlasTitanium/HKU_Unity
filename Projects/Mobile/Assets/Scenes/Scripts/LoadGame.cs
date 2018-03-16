using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour {



    private void Start()
    {
        Button currentButton = gameObject.GetComponent<Button>();
        currentButton.onClick.AddListener(TaskOnClick);
    }


    // Update is called once per frame
    void TaskOnClick () {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
