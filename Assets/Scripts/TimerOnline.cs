using UnityEngine;
using Photon.Pun;

public class TimerOnline : MonoBehaviour
{
    private GameObject textnet;
    private void Start()
    {
        textnet = GameObject.FindGameObjectWithTag("textnet");
    }
    void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            if (textnet.activeSelf)
                textnet.SetActive(false);
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount != 2)
        {
            textnet.SetActive(true);
        }
    }
}
