using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Transporting.Tugboat;

public class MultiplayerConnector : MonoBehaviour
{
    [SerializeField]
    private Tugboat tugboat;

    void Start()
    {
        tugboat.StartConnection(false);
    }
}
