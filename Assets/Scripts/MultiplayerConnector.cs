using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Transporting.Tugboat;

public class MultiplayerConnector : MonoBehaviour
{
    private Tugboat tugboat;

    void Start()
    {
        tugboat = GetComponent<Tugboat>();

        tugboat.StartConnection(false);
    }
}
