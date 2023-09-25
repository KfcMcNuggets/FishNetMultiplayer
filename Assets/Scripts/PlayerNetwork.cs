using Cinemachine;
using FishNet.Object;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    [SerializeField]
    private GameObject camKit;

    public override void OnStartClient()
    {
        base.OnStartClient();
        if (!base.IsOwner)
        {
            gameObject.name = "RemotePlayer";
            Destroy(camKit);
            GetComponent<ThirdPersonController>().enabled = false;
            //GetComponent<CharacterController>().enabled = false;
        }
        else
        {
            gameObject.name = "LocalPlayer";
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
