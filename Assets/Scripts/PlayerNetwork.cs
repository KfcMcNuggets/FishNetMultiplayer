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

    private ThirdPersonController thc;

    public override void OnStartClient()
    {
        thc = GetComponent<ThirdPersonController>();
        base.OnStartClient();
        if (!base.IsOwner)
        {
            gameObject.name = "RemotePlayer";
            Destroy(camKit);
            thc.IsActive = false;
        }
        else
        {
            gameObject.name = "LocalPlayer";
            thc.IsActive = true;
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
