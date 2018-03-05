using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using System.Collections;

namespace Prototype.NetworkLobby
{
    public class LobbyTopPanel : MonoBehaviour
    {
        public bool isInGame = false;

        public GameObject button;

        protected bool isDisplayed = true;
        protected Image panelImage;

        private bool tag = false;


        void Start()
        {
            panelImage = GetComponent<Image>();
            Button btn = button.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }

        void Update()
        {
            if(tag == false){
                if(button == null){
                    button = GameObject.FindWithTag("Settings");
                } else {
                    Button btn = button.GetComponent<Button>();
                    btn.onClick.AddListener(TaskOnClick);
                    tag = true;
                }
            }

            if (!isInGame)
                return;

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