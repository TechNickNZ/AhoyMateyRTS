using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {
    
    public void MyStartHost()
    {
        StartHost();
        Debug.Log(Time.timeSinceLevelLoad + ": Starting Host");
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Host started");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + ": Client start requested");
        InvokeRepeating("DebugDots", 0, 0.01f);
    }

    private void DebugDots()
    {
        Debug.Log(Time.timeSinceLevelLoad + ".");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        CancelInvoke("DebugDots");
        Debug.Log(Time.timeSinceLevelLoad + ": Client is connect to IP: " + conn.address);
    }
}
