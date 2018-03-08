using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Prototype.NetworkLobby
{
    public class LobbyTopPanel : MonoBehaviour
    {
        public bool isInGame = false;

        public GameObject button;

        public GameObject closebutton;
        protected bool isDisplayed = true;
        protected Image panelImage;

        private bool tag = false;


        void Start()
        {
            panelImage = GetComponent<Image>();
            Button bton = closebutton.GetComponent<Button>();
            bton.onClick.AddListener(TaskOnClick);
        }

        void Update()
        {
            if(button == null){
                Debug.Log("NOBUTTON");
                GameObject button = GameObject.FindGameObjectWithTag("Settings");
            } else {
                Debug.Log("ABUTON");
                Button btn = button.GetComponent<Button>();
                btn.onClick.AddListener(TaskOnClick);
            }

            if (!isInGame){
                Debug.Log("IMINGAME");
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ToggleVisibility(!isDisplayed);
            }

        }
 
        void TaskOnClick(){
            ToggleVisibility(!isDisplayed);
            Debug.Log("YOUCLICKEDYAY");
            Debug.Log(isDisplayed);
        }

        public void ToggleVisibility(bool visible)
        {
            isDisplayed = visible;
            foreach (Transform t in transform)
            {
                t.gameObject.SetActive(isDisplayed);
            }

            if (panelImage != null)
            {
                panelImage.enabled = isDisplayed;
            }
        }
    }
}