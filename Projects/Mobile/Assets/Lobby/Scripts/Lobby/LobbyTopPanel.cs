using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

namespace Prototype.NetworkLobby
{
    public class LobbyTopPanel : MonoBehaviour
    {
        public bool isInGame = false;

        private GameObject button;

        protected bool isDisplayed = true;
        protected Image panelImage;

        private bool TopPanelBool = false;


        void Start()
        {
            panelImage = GetComponent<Image>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ToggleVisibility(!isDisplayed);
            }

            if(TopPanelBool == true){
                if(button == null){
                    button = GameObject.FindGameObjectWithTag ("Settings");
                } else {
                    Button btn = button.GetComponent<Button>();
                    btn.onClick.AddListener(TaskOnClick);
                    TopPanelBool = false;
                }
            }

            if (!isInGame){
                TopPanelBool = true;
                return;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ToggleVisibility(!isDisplayed);
            }

        }
        void TaskOnClick(){
            ToggleVisibility(!isDisplayed);
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