using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class StartHostin : NetworkManager {

    public Button Host;
	public Button Client;
	void Start()
    {
        Button Hbtn = Host.GetComponent<Button>();
        Hbtn.onClick.AddListener(TaskOnClickHost);
		Button Cbtn = Client.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnClickClient);
    }

    void TaskOnClickHost()
    {
        StartHost();
    }

	void TaskOnClickClient()
    {
        StartClient();
		if (NetworkClient.active && !ClientScene.ready)
        {
            ClientScene.Ready(client.connection);
 
            if (ClientScene.localPlayers.Count == 0)
            {
                ClientScene.AddPlayer(0);
            }
    }
}
}