using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class TimerOnlineOsn : MonoBehaviourPunCallbacks
{
    private bool isStarted = false;
    public float timer = 0f;
    private PhotonView pv;

    public GameObject yyes;
    public Animation time;
    public bool vse = false;

    void Start()
    {
        GetComponent<Animator>().speed = 0f;
        pv = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            isStarted = true;
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount != 2)
        {
            isStarted = false;
        }
        if (isStarted)
        {
            timer += Time.deltaTime;
            pv.RPC("timerStart", RpcTarget.All, timer);
        }
    }
    [PunRPC]
    public void timerStart(float taym)
    {
        if (vse) return;
        GetComponentInChildren<Text>().text = (300 - System.Convert.ToInt32(taym)).ToString() + " sec";
        if (taym >= 290f)
        {
            GetComponent<Animator>().speed = 1f;
        }
        if (taym >= 300f)
        {
            if (GameObject.FindGameObjectWithTag("Respawn"))
            {
                GameObject.FindGameObjectWithTag("Respawn").SetActive(false);
            }
            GetComponent<Animator>().speed = 0f;
            yyes.SendMessage("OnMouseUpAsButton");
            GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().MoN = true;
            GameObject.FindGameObjectWithTag("stop").SendMessage("OnMouseUpAsButton");
            vse = true;
        }
    }
}
