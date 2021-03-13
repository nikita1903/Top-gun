using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Network : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public GameObject top;
    private string naim;
    void Start()
    {
        PhotonNetwork.NickName = "Player "+(Random.Range(1000, 9999));
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("сделала");
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Подключенно к мастеру");
        top.GetComponent<Text>().text = "Online";
    }
    public void CreateRoom()
    {
        int b = Random.Range(0, 99999);
        string v = b.ToString();
        PhotonNetwork.CreateRoom(v, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
        PlayerPrefs.SetString("nameRoom", v);
        Debug.Log("ви - " + PlayerPrefs.GetString("nameRoom"));
    }
    public void naima()
    {
        JoinRoom("random");
    }
    public void naima1()
    {
        JoinRoom("nerandom");
    }
    public void JoinRoom(string sa)
    {
        if(sa == "random")  PhotonNetwork.JoinRandomRoom();
        if(sa != "random")
        {
            Debug.Log("сделалось 11");
            string s = GameObject.FindGameObjectWithTag("avga").GetComponent<Text>().text;
            if (s != "enter the number" && s != "")
            {
                PhotonNetwork.JoinRoom(s);
                Debug.Log("сделалось 2" + s);
                return;
            }
        }
        
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene 1");
    }
}
