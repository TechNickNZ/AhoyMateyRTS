using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
    
    public void MyStartHost()
    {
        StartHost();
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
    }

    public override void OnStartHost()
    {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }
}
