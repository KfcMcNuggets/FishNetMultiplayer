using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Transporting.Tugboat;
using FishNet.Transporting;
using FishNet;
using UnityEngine.SceneManagement;

public class MultiplayerConnector : MonoBehaviour
{
    [SerializeField]
    private Tugboat tugboat;

    void Start()
    {
        tugboat.StartConnection(false);
    }

    private void OnEnable()
    {
        InstanceFinder.ClientManager.OnClientConnectionState += OnClientConnectionState;
    }

    private void OnDisable()
    {
        InstanceFinder.ClientManager.OnClientConnectionState -= OnClientConnectionState;
    }

    private void OnClientConnectionState(ClientConnectionStateArgs args)
    {
        if (args.ConnectionState == LocalConnectionState.Stopped)
        {
            Debug.Log("ConnectionLost");
            SceneManager.LoadScene(SceneNums.SINGLEPLAYER_LOBBY);
        }
    }
}
