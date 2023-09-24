using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using FishNet.Transporting.Tugboat;

public class AppStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject netPrefab;

    private const int GAME_SCENE = 1;

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
        Debug.Log("ImClinet");
        ///Delete on release

        SceneManager.LoadScene(GAME_SCENE);
    }
}
