using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool otkr = false;
    public GameObject[] children;
    public GameObject english;
    public GameObject russia;
    public GameObject phon;
    public GameObject close;
    public GameObject rusopis;
    public GameObject englopis;
    private float b = 5.1f;
    public GameObject textCont;
    private void Start()
    {
     //   if (PlayerPrefs.GetInt("RussiaProverka") != 1) PlayerPrefs.SetInt("Russia", 1);
       // PlayerPrefs.SetInt("RussiaProverka", 1);
    }
    void OnMouseUpAsButton()
    {
        if (this.gameObject.name == "Settings")
        {
            if(PlayerPrefs.GetInt("Russia") == 1)
            {
            english.SetActive(false);
            russia.SetActive(true);
            }
            Debug.Log("D");
            if (otkr == false)
            {

                Debug.Log("D1");
                otkr = true;
                GetComponent<Animation>().Play("New Animation3");
                for (int i = 0; i <= 3; i++)
                {
                    children[i].GetComponent<Animation>().Play();
                    //children[i].GetComponent<Transform>().position = new Vector3(children[i].transform.position.x, b, children[i].transform.position.z);
                }
                children[2].GetComponent<Animation>().Play("Vniz2");
                children[3].GetComponent<Animation>().Play("Vniz3");
                return;
            }
            if (otkr == true)
            {
                Debug.Log("D2");
                otkr = false;
                GetComponent<Animation>().Play("New Animation4");
                children[0].GetComponent<Animation>().Play("Vnizz");
                children[1].GetComponent<Animation>().Play("Vniz1z");
                children[2].GetComponent<Animation>().Play("Vniz2z");
                children[3].GetComponent<Animation>().Play("Vniz3z");
            }
            return;
        }
        if(this.gameObject.name == "england")
        {
            PlayerPrefs.SetInt("Russia", 1);
            english.SetActive(false);
            russia.SetActive(true);
            return;
        }
        if(this.gameObject.name == "russia")
        {
            PlayerPrefs.SetInt("Russia", 0);
            english.SetActive(true);
            russia.SetActive(false);
            return;
        }
        if(this.gameObject.name == "ask")
        {
            if (phon.activeSelf)
            {
                phon.SetActive(false);
                return;
            }
            if (phon.activeSelf == false)
            {
                phon.SetActive(true);
            }
        }
        if(this.gameObject.name == "close")
        {
            phon.SetActive(false);
        }
    }
    private void Update()
    {
        if (this.gameObject.name == "ask")
        {
            if (PlayerPrefs.GetInt("Russia") == 1)
            {
                textCont.GetComponent<ScrollRect>().content = rusopis.GetComponent<RectTransform>();
                englopis.SetActive(false);
                rusopis.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Russia") == 0)
            {
                textCont.GetComponent<ScrollRect>().content = englopis.GetComponent<RectTransform>();
                englopis.SetActive(true);
                rusopis.SetActive(false);
            }
        }
    }
}
