using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using FishNet.Transporting.Tugboat;
using FishNet.Connection;

public class AppStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject netPrefab;

    private void Start()
    {
#if UNITY_SERVER && !UNITY_EDITOR
        StartServer();
#else
        StartClient();
#endif
    }

    private void StartServer()
    {
        Debug.Log("ImServer");
        GameObject netObj = Instantiate(netPrefab);
        Tugboat tugboat = netObj.GetComponent<Tugboat>();
        tugboat.StartConnection(true);
    }

    private void StartClient()
    {
        Debug.Log("ImClient");

        SceneManager.LoadSceneAsync(SceneNums.SINGLEPLAYER_LOBBY);
    }
}
