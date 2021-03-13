using Photon.Pun;
using UnityEngine;

public class MusorkaOnline : MonoBehaviourPunCallbacks
{
    public GameObject chor;
    public Sprite kr;
    public Sprite chorsp;
    public static int musor;
    public bool udol = false;
    private PhotonView pva;
    private void Start()
    {
        pva = GetComponent<PhotonView>();
    }
    public void OnMouseUpAsButton()
    {
        if (gameObject.name == "chor" && gameObject.tag == "GameController")
        {
            pva.RPC("calara", RpcTarget.All);
        }
    }
    [PunRPC]
    public void calara()
    {
            if (udol == false)
            {
                chor.GetComponent<SpriteRenderer>().sprite = kr;
                udol = true;
                PlayerPrefs.SetInt("musor", 1);
                return;
            }
            else if (udol == true)
            {
                chor.GetComponent<SpriteRenderer>().sprite = chorsp;
                udol = false;
                PlayerPrefs.SetInt("musor", 0);
                return;
            }
    }
}
