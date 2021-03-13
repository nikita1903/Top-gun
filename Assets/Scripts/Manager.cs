using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Manager : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject player;
    void Start()
    {
            PhotonNetwork.Instantiate(player.name, new Vector2(Random.Range(-5, 5), 0), Quaternion.identity);
            Debug.Log("инстан");
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3627907", false);
        }
    }

    public void Leave()
    {
        GameObject.FindGameObjectWithTag("Doski").GetComponent<ChangeColor>().go(0, "sir", 2);
if (Advertisement.IsReady())
            {
            if (PlayerPrefs.GetInt("vid") != 4)
            {
                Advertisement.Show("video");
                PlayerPrefs.SetInt("vid", 4);
            }
            else
            {
                PlayerPrefs.SetInt("vid", 0);
            }
            }
        PhotonNetwork.LeaveRoom();
            
    }
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }
}
