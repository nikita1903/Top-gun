using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject panel;
    public GameObject yon;
    public GameObject loser;
    public GameObject losercar;
    public GameObject sport;
    public GameObject sportcar;
    public GameObject sredneman;
    public GameObject left;
    public GameObject right;
    public GameObject backpack;
    public int score;
    public int brown;
    public int red;
    public int sir;
    public int stena;
    public int door;
    public int tree;
    public int flower;
    public int kamin;
    public int divan;
    public int zabor;
    public int tv;
    public int phone;
    public int table;
    public int comp;
    public bool perev;
    public bool bilo;
    public int balance;
    public int zvezdi;

    public int lampa;
    public int bed;
    public int shkaf;
    public int tumb;
    public int xolod;
    public int aqua;
    public int vodop;
    public int stiral;
    public int tualet;

    public int dog;
    public int cat;
    public int vanna;
    public int derevo;


    public Text skolko;
    public Sprite klass;
    public bool MoN = false;

    public GameObject set;
    public GameObject stopa;
    public GameObject mens;
    public GameObject mus;

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        backpack = GameObject.FindGameObjectWithTag("BackPack");
      //  stopa = GameObject.FindGameObjectWithTag("stop");

        // if (gameObject.name == "close")
        //{
        //  panel.SetActive(true);
        //  backpack = GameObject.FindGameObjectWithTag("BackPack");
        //}

    }
    void OnMouseUpAsButton()
    {
        if (gameObject.tag == "stop" && MoN == false)
        {
            if (GameObject.FindGameObjectWithTag("Respawn") || GameObject.FindGameObjectWithTag("PanelBackPack"))
            {
                return;
            }
            if(!panel.activeInHierarchy)
            yon.SetActive(true);
            if(PlayerPrefs.GetInt("Russia") == 1)yon.GetComponentInChildren<Text>().text = "Вы уверены?";
        }
        if(gameObject.name == "No")
        {
            yon.SetActive(false);
        }
        if (gameObject.name == "Yes")
        {
            if (GameObject.FindGameObjectWithTag("Respawn"))
            {
                yon.SetActive(false);
                return;
            }
            GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().MoN = true;
            GameObject.FindGameObjectWithTag("stop").SendMessage("OnMouseUpAsButton");
            if (SceneManager.GetActiveScene().buildIndex == 1)
                if (PlayerPrefs.GetInt("Russia") == 1) GameObject.FindGameObjectWithTag("again").GetComponentInChildren<Text>().text = "Старт";
            if (PlayerPrefs.GetInt("Russia") == 1) GameObject.FindGameObjectWithTag("menu").GetComponentInChildren<Text>().text = "Меню";
            Debug.Log("bib");
        }
        if(gameObject.tag == "stop" && MoN == true) {
            if (GameObject.FindGameObjectWithTag("Respawn"))
                {
                    return;
                }
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            set = GameObject.FindGameObjectWithTag("set");
            panel.transform.GetChild(0).GetComponent<Score>().stopa = GameObject.FindGameObjectWithTag("stop");
            //Debug.Log(panel.transform.GetChild(0).name + " и " + GameObject.FindGameObjectWithTag("stop").transform + "и" + panel.transform.GetChild(0).GetComponent<Score>().stopa);
            stopa = GameObject.FindGameObjectWithTag("stop");
            mens = GameObject.FindGameObjectWithTag("perevx");
            mus = GameObject.FindGameObjectWithTag("GameController");
            set.SetActive(false);
            stopa.SetActive(false);
            mens.SetActive(false);
            mus.SetActive(false);

            yon.SetActive(false);
            panel.SetActive(true);
            left.SetActive(false);
            right.SetActive(false);
           
            backpack.SetActive(false);
            if (GameObject.FindGameObjectWithTag("PanelBackPack"))
            GameObject.FindGameObjectWithTag("PanelBackPack").SetActive(false);
            if (bilo == false)
            {
                zvezdi = 0;
                if (door >= 1 && flower >= 1 && kamin >= 1 && divan >= 1 && zabor >= 1 && tv >= 1 && phone >= 1 && table >= 1 && comp >= 1)
                {
                    if (brown >= 1 || red >= 1 || sir >= 1)
                    {
                        zvezdi += 1;
                    }
                }
                if (brown >= 20 || red >= 20 || sir >= 20) zvezdi += 1;
                if (brown + sir + stena + red + tree >= 45) zvezdi += 1;
                if (zabor >= 1) zvezdi += 1;
                if (divan >= 1 && table >= 1) zvezdi += 2;
                if (kamin >= 2) zvezdi -= 1;
                if (lampa >= 1) zvezdi += 1;
                if (bed < 1) zvezdi -= 1;
                if (aqua >= 1) zvezdi += 1;
                if (stiral >= 1 || tualet >= 1) zvezdi += 1;
                if (xolod >= 1) zvezdi += 1;
                if (flower == 0 && derevo == 0) zvezdi -= 1;
                if (flower >= 1 || derevo >= 1) zvezdi += 1;
                if (door >= 1) zvezdi += 1;
                if (perev == false || perev == true) zvezdi += 1;
                if (PlayerPrefs.GetInt("balance") >= 150000) zvezdi += 2;
                if (brown <= 15 && sir <= 15 && red <= 15 && stena <= 15 && tree <= 15) zvezdi -= 3;
                if (dog == 1 || cat == 1) zvezdi += 1;
                if (dog == 0 && cat == 0) zvezdi -= 1;
            }
            if (zvezdi < 0) zvezdi = 0;
            if (zvezdi >= 0 && zvezdi <= 3)
            {
                sport.SetActive(false);
                sportcar.SetActive(false);
                sredneman.SetActive(false);
                losercar.SetActive(false);
                loser.SetActive(true);
                losercar.SetActive(true);
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraContrl>().stop = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>().position = new Vector3(65f, -0.49f, -10);
                skolko.text = "Badly";
                if (PlayerPrefs.GetInt("Russia") == 1) skolko.text = "Плохо";
                    GameObject.FindGameObjectWithTag("audio1").GetComponent<AudioSource>().Play();
            }
            if (zvezdi >= 4 && zvezdi <= 7)
            {
                skolko.text = "Good";
                sport.SetActive(false);
                sportcar.SetActive(false);
                loser.SetActive(false);
                sredneman.SetActive(true);
                losercar.SetActive(true);
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraContrl>().stop = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>().position = new Vector3(65f, -0.49f, -10);
                if (PlayerPrefs.GetInt("Russia") == 1) skolko.text = "Хорошо";
                    GameObject.FindGameObjectWithTag("audio2").GetComponent<AudioSource>().Play();
            }
            if (zvezdi >= 8) {
                GameObject.FindGameObjectWithTag("audio2").GetComponent<AudioSource>().Play();
                skolko.text = "Epic"; if (PlayerPrefs.GetInt("Russia") == 1) skolko.text = "Отлично";
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraContrl>().stop = true;
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>().position = new Vector3(65f, -0.49f, -10);
                sredneman.SetActive(false);
                losercar.SetActive(false);
                loser.SetActive(false);
                sport.SetActive(true);
                sportcar.SetActive(true);
            }
            for(int i = 1; i <= zvezdi; i++)
            {
                GameObject.FindGameObjectWithTag("zv" + i).GetComponent<Animation>().Play();
            }
        }
        if(gameObject.tag == "again")
        {
                SceneManager.LoadScene(1);
        }
        if (gameObject.tag == "menu")
        {
            if (SceneManager.GetActiveScene().buildIndex != 2)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().Leave();
            }
        }
        if(gameObject.name == "close")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            stopa.GetComponent<Score>().set.SetActive(true);
            stopa.GetComponent<Score>().mus.SetActive(true);
           stopa.SetActive(true);
            stopa.GetComponent<Score>().mens.SetActive(true);


            panel.SetActive(false);
            left.SetActive(true);
            right.SetActive(true);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
               this.gameObject.GetComponent<Score>().backpack  = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerContrlNet>().panback;
                    
            }
            backpack.SetActive(true);
                GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraContrl>().stop = false;
        }
    }
}
