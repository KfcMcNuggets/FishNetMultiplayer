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
#if UNITY_EDITOR
        tugboat.StartConnection(true);
#endif
        tugboat.StartConnection(false);
    }
}
