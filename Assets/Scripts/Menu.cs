using UnityEngine.SceneManagement;
using UnityEngine;
using Photon.Pun;

public class Menu : MonoBehaviour
{
    public Sprite m_on;
    public Sprite m_off;
    void OnMouseUpAsButton()
    {
        if (gameObject.name == "Play")
        {
            if (PlayerPrefs.GetInt("music") == 0)
                GetComponent<AudioSource>().Play();
            if(PhotonNetwork.IsConnected)
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene(1);
        }
        if(gameObject.name == "musicIsOn")
        {
            if (GetComponent<AudioSource>().mute == false)
            {
                GetComponent<AudioSource>().mute = true;
                GetComponent<SpriteRenderer>().sprite = m_off;
                PlayerPrefs.SetInt("music", 1);
            }
            else
            {
                GetComponent<AudioSource>().mute = false;
                GetComponent<SpriteRenderer>().sprite = m_on;
                PlayerPrefs.SetInt("music", 0);
                gameObject.GetComponent<AudioSource>().enabled = true;
            }
        }
    }
    private void Start()
    {
        if (gameObject.name == "Play") return;
        if (gameObject.name == "musicIsOn")
        {
            if (PlayerPrefs.GetInt("music") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = m_off;
                GetComponent<AudioSource>().mute = true;
            }
        }
        if(PlayerPrefs.GetInt("music") == 1)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
    }
}
