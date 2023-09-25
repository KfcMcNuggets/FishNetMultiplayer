using System.Collections;
using UnityEngine;
using StarterAssets;
using FishNet.Transporting.Tugboat;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private ThirdPersonController thc;

    void Start()
    {
        thc = GetComponent<ThirdPersonController>();
        thc.IsActive = true;
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Portal"))
        {
            SceneManager.LoadScene(SceneNums.MUPLTIPLAYER_PLAYGROUND);
        }
    }
}
