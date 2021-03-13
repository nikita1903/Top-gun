using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour
{
    private GameObject panka;
    public Text vsego;
    private GameObject bal;
    public int x = 1;

    private GameObject b;
    private GameObject[] pap = new GameObject[7];
    private GameObject[] pip = new GameObject[5];

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
            PlayerPrefs.SetInt("balance", 300000);
        panka = GameObject.FindGameObjectWithTag("Respawn");
    }
    void Updating()
    {
         switch (gameObject.name)
        {
            case "brown":
                    vsego.text = PlayerPrefs.GetInt("brown").ToString();
                break;
            case "red":
                    vsego.text = PlayerPrefs.GetInt("red").ToString();
                break;
            case "sir":
                    vsego.text = PlayerPrefs.GetInt("sir").ToString();
                break;
            case "stena":
                    vsego.text = PlayerPrefs.GetInt("stena").ToString();
                break;
            case "door":
                    vsego.text = PlayerPrefs.GetInt("door").ToString();
                break;
            case "tree":
                    vsego.text = PlayerPrefs.GetInt("tree").ToString();
                break;
            case "flower":
                    vsego.text = PlayerPrefs.GetInt("flower").ToString();
                break;
            case "kamin":
                    vsego.text = PlayerPrefs.GetInt("kamin").ToString();
                break;
            case "divan":
                    vsego.text = PlayerPrefs.GetInt("divan").ToString();
                break;
            case "tv":
                    vsego.text = PlayerPrefs.GetInt("tv").ToString();
                break;
            case "zabor":
                    vsego.text = PlayerPrefs.GetInt("zabor").ToString();
                break;
            case "phone":
                    vsego.text = PlayerPrefs.GetInt("phone").ToString();
                break;
            case "table":
                    vsego.text = PlayerPrefs.GetInt("table").ToString();
                break;
            case "comp":
                    vsego.text = PlayerPrefs.GetInt("comp").ToString();
                break;
       } 
    }
    
    public void OnMouseDowna()
    {
        int x = GameObject.FindGameObjectWithTag("but").GetComponent<ShopControl>().x;
        switch (gameObject.name)
        {
            case "Furn":
                
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    gameObject.transform.GetChild(i).gameObject.SetActive(true);
                    if (gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>())
                    {
                        gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>().vsego.text = PlayerPrefs.GetInt(gameObject.transform.GetChild(i).gameObject.name).ToString();
                    }
                }
                pap = GameObject.FindGameObjectsWithTag("newtag");
                for(int i = 0;i < pap.Length; i++)
                {
                    if (this.gameObject == pap[i]) continue;
                    pap[i].SetActive(false);
                }
                break;
            case "Walls":
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    gameObject.transform.GetChild(i).gameObject.SetActive(true);
                    if (gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>())
                        gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>().vsego.text = PlayerPrefs.GetInt(gameObject.transform.GetChild(i).gameObject.name).ToString();
                }
                pap = GameObject.FindGameObjectsWithTag("newtag");
                for (int i = 0; i < pap.Length; i++)
                {
                    if (this.gameObject == pap[i]) continue;
                    pap[i].SetActive(false);
                }
                break;
            case "Outside features":
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    gameObject.transform.GetChild(i).gameObject.SetActive(true);
                    if (gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>())
                        gameObject.transform.GetChild(i).gameObject.GetComponent<ShopControl>().vsego.text = PlayerPrefs.GetInt(gameObject.transform.GetChild(i).gameObject.name).ToString();
                }
                pap = GameObject.FindGameObjectsWithTag("newtag");
                for (int i = 0; i < pap.Length; i++)
                {
                    if (this.gameObject == pap[i]) continue;
                    pap[i].SetActive(false);
                }
                break;
            case "brown":
                if (PlayerPrefs.GetInt("balance") >= 500*x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 500 * x);
                    PlayerPrefs.SetInt("brown", PlayerPrefs.GetInt("brown") + x);
                    vsego.text = PlayerPrefs.GetInt("brown").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                    Debug.Log("d");
                }
                break;
            case "red":
                if (PlayerPrefs.GetInt("balance") >= 500*x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 500 * x);
                    PlayerPrefs.SetInt("red", PlayerPrefs.GetInt("red") + x);
                    vsego.text = PlayerPrefs.GetInt("red").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "sir":
                if (PlayerPrefs.GetInt("balance") >= 500 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 500 * x);
                    PlayerPrefs.SetInt("sir", PlayerPrefs.GetInt("sir") + x);
                    vsego.text = PlayerPrefs.GetInt("sir").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stena":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stena", PlayerPrefs.GetInt("stena") + x);
                    vsego.text = PlayerPrefs.GetInt("stena").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stenaGreen":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stenaGreen", PlayerPrefs.GetInt("stenaGreen") + x);
                    vsego.text = PlayerPrefs.GetInt("stenaGreen").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stenaFiol":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stenaFiol", PlayerPrefs.GetInt("stenaFiol") + x);
                    vsego.text = PlayerPrefs.GetInt("stenaFiol").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stenaBlue":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stenaBlue", PlayerPrefs.GetInt("stenaBlue") + x);
                    vsego.text = PlayerPrefs.GetInt("stenaBlue").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stenaRed":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stenaRed", PlayerPrefs.GetInt("stenaRed") + x);
                    vsego.text = PlayerPrefs.GetInt("stenaRed").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stenaYeloww":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("stenaYeloww", PlayerPrefs.GetInt("stenaYeloww") + x);
                    vsego.text = PlayerPrefs.GetInt("stenaYeloww").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "door":
                if (PlayerPrefs.GetInt("balance") >= 2000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 2000 * x);
                    PlayerPrefs.SetInt("door", PlayerPrefs.GetInt("door") + x);
                    vsego.text = PlayerPrefs.GetInt("door").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "tree":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("tree", PlayerPrefs.GetInt("tree") + x);
                    vsego.text = PlayerPrefs.GetInt("tree").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "flower":
                if (PlayerPrefs.GetInt("balance") >= 300 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 300 * x);
                    PlayerPrefs.SetInt("flower", PlayerPrefs.GetInt("flower") + x);
                    vsego.text = PlayerPrefs.GetInt("flower").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "kamin":
                if (PlayerPrefs.GetInt("balance") >= 8000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 8000 * x);
                    PlayerPrefs.SetInt("kamin", PlayerPrefs.GetInt("kamin") + x);
                    vsego.text = PlayerPrefs.GetInt("kamin").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "divan":
                if (PlayerPrefs.GetInt("balance") >= 2000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 2000 * x);
                    PlayerPrefs.SetInt("divan", PlayerPrefs.GetInt("divan") + x);
                    vsego.text = PlayerPrefs.GetInt("divan").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "tv":
                if (PlayerPrefs.GetInt("balance") >= 5000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 5000 * x);
                    PlayerPrefs.SetInt("tv", PlayerPrefs.GetInt("tv") + x);
                    vsego.text = PlayerPrefs.GetInt("tv").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "zabor":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("zabor", PlayerPrefs.GetInt("zabor") + x);
                    vsego.text = PlayerPrefs.GetInt("zabor").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "phone":
                if (PlayerPrefs.GetInt("balance") >= 500 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 500 * x);
                    PlayerPrefs.SetInt("phone", PlayerPrefs.GetInt("phone") + x);
                    vsego.text = PlayerPrefs.GetInt("phone").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "table":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("table", PlayerPrefs.GetInt("table") + x);
                    vsego.text = PlayerPrefs.GetInt("table").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "comp":
                if (PlayerPrefs.GetInt("balance") >= 7000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 7000 * x);
                    PlayerPrefs.SetInt("comp", PlayerPrefs.GetInt("comp") + x);
                    vsego.text = PlayerPrefs.GetInt("comp").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "lampa":
                if (PlayerPrefs.GetInt("balance") >= 1500 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1500 * x);
                    PlayerPrefs.SetInt("lampa", PlayerPrefs.GetInt("lampa") + x);
                    vsego.text = PlayerPrefs.GetInt("lampa").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "bed":
                if (PlayerPrefs.GetInt("balance") >= 2000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 2000 * x);
                    PlayerPrefs.SetInt("bed", PlayerPrefs.GetInt("bed") + x);
                    vsego.text = PlayerPrefs.GetInt("bed").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "shkaf":
                if (PlayerPrefs.GetInt("balance") >= 3000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 3000 * x);
                    PlayerPrefs.SetInt("shkaf", PlayerPrefs.GetInt("shkaf") + x);
                    vsego.text = PlayerPrefs.GetInt("shkaf").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "tumb":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("tumb", PlayerPrefs.GetInt("tumb") + x);
                    vsego.text = PlayerPrefs.GetInt("tumb").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "xolod":
                if (PlayerPrefs.GetInt("balance") >= 4000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 4000 * x);
                    PlayerPrefs.SetInt("xolod", PlayerPrefs.GetInt("xolod") + x);
                    vsego.text = PlayerPrefs.GetInt("xolod").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "aqua":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("aqua", PlayerPrefs.GetInt("aqua") + x);
                    vsego.text = PlayerPrefs.GetInt("aqua").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "stiral":
                if (PlayerPrefs.GetInt("balance") >= 3500 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 3500 * x);
                    PlayerPrefs.SetInt("stiral", PlayerPrefs.GetInt("stiral") + x);
                    vsego.text = PlayerPrefs.GetInt("stiral").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "vodop":
                if (PlayerPrefs.GetInt("balance") >= 10000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 3500 * x);
                    PlayerPrefs.SetInt("vodop", PlayerPrefs.GetInt("vodop") + x);
                    vsego.text = PlayerPrefs.GetInt("vodop").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "tualet":
                if (PlayerPrefs.GetInt("balance") >= 3500 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 3500 * x);
                    PlayerPrefs.SetInt("tualet", PlayerPrefs.GetInt("tualet") + x);
                    vsego.text = PlayerPrefs.GetInt("tualet").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "derevo":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("derevo", PlayerPrefs.GetInt("derevo") + x);
                    vsego.text = PlayerPrefs.GetInt("derevo").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "vanna":
                if (PlayerPrefs.GetInt("balance") >= 4000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 4000 * x);
                    PlayerPrefs.SetInt("vanna", PlayerPrefs.GetInt("vanna") + x);
                    vsego.text = PlayerPrefs.GetInt("vanna").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "cat":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("cat", PlayerPrefs.GetInt("cat") + x);
                    vsego.text = PlayerPrefs.GetInt("cat").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "dog":
                if (PlayerPrefs.GetInt("balance") >= 1000 * x)
                {
                    PlayerPrefs.SetInt("balance", PlayerPrefs.GetInt("balance") - 1000 * x);
                    PlayerPrefs.SetInt("dog", PlayerPrefs.GetInt("dog") + x);
                    vsego.text = PlayerPrefs.GetInt("dog").ToString();
                    GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().Play();
                }
                break;
            case "exit":
                for (int i = 0; i <= 4; i++)
                {

                    panka.transform.GetChild(i).gameObject.SetActive(true);
                    pip[i] = panka.transform.GetChild(i).gameObject;
                    Debug.Log(pip[i].name + " " + i);
                }
                for (int i = 2; i <= 4; i++)
                {
                    for (int j = 0; j < pip[i].transform.childCount; j++)
                    {
                        pip[i].transform.GetChild(j).gameObject.SetActive(false);
                    }
                    pip[i].transform.GetChild(0).gameObject.SetActive(true);
                    pip[i].transform.GetChild(1).gameObject.SetActive(true);
                }
                break;
        }
        if(PlayerPrefs.GetInt("Russia") == 0)GameObject.FindGameObjectWithTag("havebalance").GetComponent<Text>().text = "Balance: " + PlayerPrefs.GetInt("balance").ToString() + "$";
        if (PlayerPrefs.GetInt("Russia") == 1) GameObject.FindGameObjectWithTag("havebalance").GetComponent<Text>().text = "Баланс: " + PlayerPrefs.GetInt("balance").ToString() + "$";
    }
    public void Clicking()
    {
     if (x == 4) { x = 0; }
            x = x + 1;
            GetComponentInChildren<Text>().text = x + "x";
        
    }
    
}
