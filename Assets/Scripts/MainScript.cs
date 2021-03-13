using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    private GameObject[] fances;
    public GameObject panel;
    public Sprite brown;
    public Sprite red;
    public Sprite sir;
    public Sprite stena;
    public Sprite door1;
    public Sprite door2;
    public Sprite tree;
    public Sprite flower;
    public Sprite kamin;
    public Sprite divan;
    public Sprite zabor;
    public Sprite tv;
    public Sprite phone;
    public Sprite table;
    public Sprite comp;
    public Sprite fance;
    public Sprite dont;
    private Sprite b;
    public Sprite lampa;
    public Sprite bed;
    public Sprite shkaf;
    public Sprite tumb;
    public Sprite xolod;
    public Sprite aqua;
    public Sprite stiral;
    public Sprite vodop;
    public Sprite tualet;
    public Sprite derevo;
    public Sprite dog;
    public Sprite cat;
    public Sprite vanna;
    public bool Green;
    public bool Blue;
    public bool Yellow;
    public bool Red;
    public bool Fiol;
    public bool White;
    public bool mona = false;
    public bool resh;

    private int nom;
    private string d;
    void Start()
    {
        PlayerPrefs.SetInt("musor", 0);
        fances = GameObject.FindGameObjectsWithTag("Doski");

    }
    private void OnMouseOver()
    {
        if (GameObject.FindGameObjectWithTag("PanelBackPack"))
        {

            return;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (GameObject.FindGameObjectWithTag("textnet"))
            {
                return;
            }
        }
            if (PlayerPrefs.GetInt("musor") != 1)
        {
            if (mona == true)
            {
            for(int i = 0; i < fances.Length; i++)
                        {
                    if (this.gameObject == fances[i]) nom = i;
                            
                        }
                Sprite a = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                if (a == brown || a == red || a == sir || a == stena || a == door1 || a == door2 || a == tree || a == flower || a == kamin || a == divan || a == zabor || a == tv || a == phone || a == table || a == comp || a == lampa || a == bed || a == shkaf || a == tumb || a == xolod || a == aqua || a == stiral || a == vodop || a == tualet || a == vanna || a == cat || a == dog || a == derevo)
                {
                    return;
                }
                
                if (PlayerPrefs.GetInt("brown") >= 1 && PlayerPrefs.GetString("brown1") == "yes")
                {
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = brown;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("brown", PlayerPrefs.GetInt("brown") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().brown += 1;
                    this.gameObject.SetActive(true);
                    GameObject.FindGameObjectWithTag("audio4").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2) {
                        
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "brown", 0);
                        Debug.Log("1: " + this.gameObject.name);
                    }
                    return;
                }
                if (PlayerPrefs.GetInt("red") >= 1 && PlayerPrefs.GetString("red1") == "yes")
                {
                    GameObject b = this.gameObject;
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = red;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("red", PlayerPrefs.GetInt("red") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().red += 1;
                    GameObject.FindGameObjectWithTag("audio4").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "red", 0);
                        Debug.Log("1: " + this.gameObject.name);
                    }
                    return;
                }
                if (PlayerPrefs.GetInt("sir") >= 1 && PlayerPrefs.GetString("sir1") == "yes")
                {
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = sir;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("sir", PlayerPrefs.GetInt("sir") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().sir += 1;
                    GameObject.FindGameObjectWithTag("audio4").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "sir", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("door") >= 1 && PlayerPrefs.GetString("door1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) {  Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return;}
                    bool b = false;
                    float etotY = this.gameObject.GetComponent<Transform>().position.y;
                    float etotX = this.gameObject.GetComponent<Transform>().position.x;
                    float sledY;
                    for (int i = 0; i < fances.Length; i++)
                    {
                        sledY = fances[i].GetComponent<Transform>().position.y;
                        float eto = sledY - etotY;
                        float sledX = fances[i].GetComponent<Transform>().position.x;
                        if (eto == 1.0f && sledX == etotX && fances[i].GetComponent<SpriteRenderer>().sprite == dont)
                        {
                            fances[i].GetComponent<SpriteRenderer>().sprite = door1;
                            fances[i].GetComponent<FanceInfo>().YesOrNo = true;
                            fances[i].GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                            // fances[i].GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                            Debug.Log("Фанке " + i);
                            b = true;
                            break;
                        }
                    }
                    if (b == false) return;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = door2;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    //this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    PlayerPrefs.SetInt("door", PlayerPrefs.GetInt("door") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().door += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "door1", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("stena") >= 1 && PlayerPrefs.GetString("stena1") == "yes")
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("stena", PlayerPrefs.GetInt("stena") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1; 
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stena", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().White = true;
                    return;
                }
                if (PlayerPrefs.GetInt("stenaGreen") >= 1 && PlayerPrefs.GetString("stenaGreen1") == "yes")
                {
                    Debug.Log("ЮХУУ");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.25f, 0.9f, 0.3f);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f); 
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("stenaGreen", PlayerPrefs.GetInt("stenaGreen") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stenaGreen", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().Green = true;
                    return;
                }
                if (PlayerPrefs.GetInt("stenaBlue") >= 1 && PlayerPrefs.GetString("stenaBlue1") == "yes")
                {
                    
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.348f, 0.9f, 0.993f);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("stenaBlue", PlayerPrefs.GetInt("stenaBlue") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1; 
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stenaBlue", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().Blue = true;
                    return;
                }
                if (PlayerPrefs.GetInt("stenaFiol") >= 1 && PlayerPrefs.GetString("stenaFiol1") == "yes")
                {
                    Debug.Log("ЮХУУ");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.5720f, 0.1273f, 1f);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("stenaFiol", PlayerPrefs.GetInt("stenaFiol") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stenaFiol", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().Fiol = true;
                    return;
                }
                if (PlayerPrefs.GetInt("stenaRed") >= 1 && PlayerPrefs.GetString("stenaRed1") == "yes")
                {
                    Debug.Log("ЮХУУ");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 0.2f, 0f);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("stenaRed", PlayerPrefs.GetInt("stenaRed") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;


                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stenaRed", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().Red = true;
                    return;
                }
                if (PlayerPrefs.GetInt("stenaYeloww") >= 1 && PlayerPrefs.GetString("stenaYeloww1") == "yes")
                {
                    Debug.Log("ЮХУУ");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stena;
                    this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 0.9766f, 0f);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("stenaYeloww", PlayerPrefs.GetInt("stenaYeloww") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1; 
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;


                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stenaYeloww", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    this.gameObject.GetComponent<MainScript>().Yellow = true;
                    return;
                }
                if (PlayerPrefs.GetInt("lampa") >= 1 && PlayerPrefs.GetString("lampa1") == "yes")
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = lampa;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("lampa", PlayerPrefs.GetInt("lampa") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().lampa += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "lampa", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("bed") >= 1 && PlayerPrefs.GetString("bed1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.18f);
                    this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.49f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = bed;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("bed", PlayerPrefs.GetInt("bed") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().bed += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "bed", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("shkaf") >= 1 && PlayerPrefs.GetString("shkaf1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = shkaf;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("shkaf", PlayerPrefs.GetInt("shkaf") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().shkaf += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "shkaf", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("tumb") >= 1 && PlayerPrefs.GetString("tumb1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = tumb;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("tumb", PlayerPrefs.GetInt("tumb") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tumb += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "tumb", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("xolod") >= 1 && PlayerPrefs.GetString("xolod1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = xolod;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    PlayerPrefs.SetInt("xolod", PlayerPrefs.GetInt("xolod") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().xolod += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "xolod", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("aqua") >= 1 && PlayerPrefs.GetString("aqua1") == "yes")
                {

                    this.gameObject.GetComponent<SpriteRenderer>().sprite = aqua;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("aqua", PlayerPrefs.GetInt("aqua") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().aqua += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "aqua", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("stiral") >= 1 && PlayerPrefs.GetString("stiral1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = stiral;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("stiral", PlayerPrefs.GetInt("stiral") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stiral += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "stiral", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("vodop") >= 1 && PlayerPrefs.GetString("vodop1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = vodop;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("vodop", PlayerPrefs.GetInt("vodop") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().vodop += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "vodop", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("tualet") >= 1 && PlayerPrefs.GetString("tualet1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = tualet;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);

                    PlayerPrefs.SetInt("tualet", PlayerPrefs.GetInt("tualet") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tualet += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "tualet", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("tree") >= 1 && PlayerPrefs.GetString("tree1") == "yes")
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = tree;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("tree", PlayerPrefs.GetInt("tree") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tree += 1;
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "tree", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("flower") >= 1 && PlayerPrefs.GetString("flower1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.2f);
                    this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.8f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = flower;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("flower", PlayerPrefs.GetInt("flower") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().flower += 1;
                    GameObject.FindGameObjectWithTag("right").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "flower", 0);
                    }
                    return;
                }
                if (PlayerPrefs.GetInt("kamin") >= 1 && PlayerPrefs.GetString("kamin1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = kamin;
                    PlayerPrefs.SetInt("kamin", PlayerPrefs.GetInt("kamin") - 1);
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().kamin += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "kamin", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("divan") >= 1 && PlayerPrefs.GetString("divan1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = divan;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("divan", PlayerPrefs.GetInt("divan") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().divan += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "divan", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("zabor") >= 1 && PlayerPrefs.GetString("zabor1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.13f);
                    this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.75f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = zabor;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    PlayerPrefs.SetInt("zabor", PlayerPrefs.GetInt("zabor") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().zabor += 1;
                    GameObject.FindGameObjectWithTag("audio5").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "zabor", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("tv") >= 1 && PlayerPrefs.GetString("tv1") == "yes")
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = tv;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    PlayerPrefs.SetInt("tv", PlayerPrefs.GetInt("tv") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tv += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "tv", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("phone") >= 1 && PlayerPrefs.GetString("phone1") == "yes")
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = phone;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    PlayerPrefs.SetInt("phone", PlayerPrefs.GetInt("phone") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().phone += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "phone", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("table") >= 1 && PlayerPrefs.GetString("table1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = table;
                    PlayerPrefs.SetInt("table", PlayerPrefs.GetInt("table") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().table += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "table", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("comp") >= 1 && PlayerPrefs.GetString("comp1") == "yes")
                {
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = comp;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    PlayerPrefs.SetInt("comp", PlayerPrefs.GetInt("comp") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().comp += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "comp", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("dog") >= 1 && PlayerPrefs.GetString("dog1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = dog;
                    PlayerPrefs.SetInt("dog", PlayerPrefs.GetInt("dog") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().dog += 1;
                    GameObject.FindGameObjectWithTag("audio7").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "dog", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("derevo") >= 1 && PlayerPrefs.GetString("derevo1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = derevo;
                    PlayerPrefs.SetInt("derevo", PlayerPrefs.GetInt("derevo") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().derevo += 1;
                    GameObject.FindGameObjectWithTag("right").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "derevo", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("vanna") >= 1 && PlayerPrefs.GetString("vanna1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = vanna;
                    PlayerPrefs.SetInt("vanna", PlayerPrefs.GetInt("vanna") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().vanna += 1;
                    GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "vanna", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
                if (PlayerPrefs.GetInt("cat") >= 1 && PlayerPrefs.GetString("cat1") == "yes")
                {
                    if (this.gameObject.GetComponent<RectTransform>().position.y != -4.380564f) { Debug.Log(this.gameObject.GetComponent<RectTransform>().position.y); return; }
                    this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                    this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                    this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, -0.001f);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = cat;
                    PlayerPrefs.SetInt("cat", PlayerPrefs.GetInt("cat") - 1);
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                        GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().cat += 1;
                    GameObject.FindGameObjectWithTag("audio8").GetComponent<AudioSource>().Play();
                    if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "cat", 0);
                        Debug.Log("1: " + this.gameObject.name);

                    }
                    return;
                }
            }
            if (PlayerPrefs.GetString("comp1") != "yes" && PlayerPrefs.GetString("table1") != "yes" && PlayerPrefs.GetString("phone1") != "yes" && PlayerPrefs.GetString("tv1") != "yes" && PlayerPrefs.GetString("zabor1") != "yes" && PlayerPrefs.GetString("divan1") != "yes" && PlayerPrefs.GetString("kamin1") != "yes" && PlayerPrefs.GetString("flower1") != "yes" && PlayerPrefs.GetString("tree1") != "yes" && PlayerPrefs.GetString("stena1") != "yes" && PlayerPrefs.GetString("door1") != "yes" && PlayerPrefs.GetString("sir1") != "yes" && PlayerPrefs.GetString("red1") != "yes" && PlayerPrefs.GetString("brown1") != "yes" && PlayerPrefs.GetString("stenaGreen1") != "yes" && PlayerPrefs.GetString("stenaBlue1") != "yes" && PlayerPrefs.GetString("stenaFiol1") != "yes" && PlayerPrefs.GetString("stenaRed1") != "yes" && PlayerPrefs.GetString("stenaYeloww1") != "yes" && PlayerPrefs.GetString("lampa1") != "yes" && PlayerPrefs.GetString("bed1") != "yes" && PlayerPrefs.GetString("shkaf1") != "yes" && PlayerPrefs.GetString("tumb1") != "yes" && PlayerPrefs.GetString("xolod1") != "yes" && PlayerPrefs.GetString("aqua1") != "yes" && PlayerPrefs.GetString("stiral1") != "yes" && PlayerPrefs.GetString("vodop1") != "yes" && PlayerPrefs.GetString("tualet1") != "yes" && PlayerPrefs.GetString("derevo1") != "yes" && PlayerPrefs.GetString("dog1") != "yes" && PlayerPrefs.GetString("cat1") != "yes" && PlayerPrefs.GetString("vanna1") != "yes")
            {
                if (!panel.activeInHierarchy)
                {
                    GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().backpack.SendMessage("OnMouseUpAsButton");
                }
                return;
            }
        }
    }
    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("musor") == 1)
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == door1) return;
            if(this.gameObject.GetComponent<SpriteRenderer>().sprite == door2 && this.gameObject.GetComponent<FanceInfo>().YesOrNo == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = dont;
                this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, 0f);
                if (resh == true)
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                else
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
             //   this.gameObject.GetComponent<SpriteRenderer>().color = GameObject.FindGameObjectWithTag("Doski").GetComponent<SpriteRenderer>().color;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = false;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                GameObject.FindGameObjectWithTag("audio3").GetComponent<AudioSource>().Play();
                float etotY = this.gameObject.GetComponent<Transform>().position.y;
                float etotX = this.gameObject.GetComponent<Transform>().position.x;
                float sledY;
                for (int i = 0; i < fances.Length; i++)
                {
                    sledY = fances[i].GetComponent<Transform>().position.y;
                    float eto = sledY - etotY;
                    float sledX = fances[i].GetComponent<Transform>().position.x;
                    if (eto == 1.0f && sledX == etotX)
                    {
                        fances[i].gameObject.GetComponent<Transform>().position = new Vector3(fances[i].transform.position.x, fances[i].transform.position.y, 0f);
                        fances[i].gameObject.GetComponent<SpriteRenderer>().sprite = dont;
                        if (resh == true)
                            fances[i].gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                        else
                            fances[i].gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
                      //  fances[i].gameObject.GetComponent<SpriteRenderer>().color = GameObject.FindGameObjectWithTag("Doski").GetComponent<SpriteRenderer>().color;
                        fances[i].gameObject.GetComponent<FanceInfo>().YesOrNo = false;
                        fances[i].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                        break;
                    }
                }
                if (SceneManager.GetActiveScene().buildIndex == 2)
                    {
                        this.gameObject.GetComponent<ChangeColor>().go(nom, "door1", 1);
                    }
                PlayerPrefs.SetInt("door", PlayerPrefs.GetInt("door") + 1);
                return;
            }
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite != null && this.gameObject.GetComponent<FanceInfo>().YesOrNo == true)
            {
                b = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                if (b == brown) { PlayerPrefs.SetInt("brown", PlayerPrefs.GetInt("brown") + 1); d = "brown";
                }
                if (b == red) { PlayerPrefs.SetInt("red", PlayerPrefs.GetInt("red") + 1); d = "red"; }
                if (b == sir) { PlayerPrefs.SetInt("sir", PlayerPrefs.GetInt("sir") + 1); d = "sir"; }
                if (b == tree) {PlayerPrefs.SetInt("tree", PlayerPrefs.GetInt("tree") + 1); d = "tree";}
                if (b == flower) { PlayerPrefs.SetInt("flower", PlayerPrefs.GetInt("flower") + 1); d = "flower"; }
                if (b == kamin) { PlayerPrefs.SetInt("kamin", PlayerPrefs.GetInt("kamin") + 1); d = "kamin"; }
                if (b == stena) {
                    if (this.gameObject.GetComponent<MainScript>().Green) { PlayerPrefs.SetInt("stenaGreen", PlayerPrefs.GetInt("stenaGreen") + 1); d = "stenaGreen"; this.gameObject.GetComponent<MainScript>().Green = false; }
                    if (this.gameObject.GetComponent<MainScript>().Blue){ PlayerPrefs.SetInt("stenaBlue", PlayerPrefs.GetInt("stenaBlue") + 1); d = "stenaBlue"; this.gameObject.GetComponent<MainScript>().Blue = false;
                }

                if (this.gameObject.GetComponent<MainScript>().Fiol){ PlayerPrefs.SetInt("stenaFiol", PlayerPrefs.GetInt("stenaFiol") + 1); d = "stenaFiol"; this.gameObject.GetComponent<MainScript>().Fiol = false;
            }

            if (this.gameObject.GetComponent<MainScript>().Red){ PlayerPrefs.SetInt("stenaRed", PlayerPrefs.GetInt("stenaRed") + 1); d = "stenaRed"; this.gameObject.GetComponent<MainScript>().Red = false;
        }
        if (this.gameObject.GetComponent<MainScript>().Yellow){ PlayerPrefs.SetInt("stenaYeloww", PlayerPrefs.GetInt("stenaYeloww") + 1); d = "stenaYeloww"; this.gameObject.GetComponent<MainScript>().Yellow = false;
    }
                    if (this.gameObject.GetComponent<MainScript>().White){ PlayerPrefs.SetInt("stena", PlayerPrefs.GetInt("stena") + 1); d = "stena";this.gameObject.GetComponent<MainScript>().White = false; }
                }
                if (b == divan) { PlayerPrefs.SetInt("divan", PlayerPrefs.GetInt("divan") + 1); d = "divan"; }
                if (b == zabor) { PlayerPrefs.SetInt("zabor", PlayerPrefs.GetInt("zabor") + 1); d = "zabor"; }
                if (b == tv) { PlayerPrefs.SetInt("tv", PlayerPrefs.GetInt("tv") + 1); d = "tv"; }
                if (b == phone) { PlayerPrefs.SetInt("phone", PlayerPrefs.GetInt("phone") + 1); d = "phone"; }
                if (b == table) { PlayerPrefs.SetInt("table", PlayerPrefs.GetInt("table") + 1); d = "table"; }
                if (b == comp) { PlayerPrefs.SetInt("comp", PlayerPrefs.GetInt("comp") + 1); d = "comp"; }
                if (b == lampa) { PlayerPrefs.SetInt("lampa", PlayerPrefs.GetInt("lampa") + 1); d = "lampa"; }
                if (b == bed) { PlayerPrefs.SetInt("bed", PlayerPrefs.GetInt("bed") + 1); d = "bed"; }
                if (b == shkaf) { PlayerPrefs.SetInt("shkaf", PlayerPrefs.GetInt("shkaf") + 1); d = "shkaf"; }
                if (b == tumb) { PlayerPrefs.SetInt("tumb", PlayerPrefs.GetInt("tumb") + 1); d = "tumb"; }
                if (b == xolod) { PlayerPrefs.SetInt("xolod", PlayerPrefs.GetInt("xolod") + 1); d = "xolod"; }
                if (b == aqua) { PlayerPrefs.SetInt("aqua", PlayerPrefs.GetInt("aqua") + 1); d = "aqua"; }
                if (b == tualet) { PlayerPrefs.SetInt("tualet", PlayerPrefs.GetInt("tualet") + 1); d = "tualet"; }
                if (b == stiral) { PlayerPrefs.SetInt("stiral", PlayerPrefs.GetInt("stiral") + 1); d = "stiral"; }
                if (b == vodop) { PlayerPrefs.SetInt("vodop", PlayerPrefs.GetInt("vodop") + 1); d = "vodop"; }
                if (b == dog) { PlayerPrefs.SetInt("dog", PlayerPrefs.GetInt("dog") + 1); d = "dog"; }
                if (b == cat) { PlayerPrefs.SetInt("cat", PlayerPrefs.GetInt("cat") + 1); d = "cat"; }
                if (b == vanna) { PlayerPrefs.SetInt("vanna", PlayerPrefs.GetInt("vanna") + 1); d = "vanna"; }
                if (b == derevo) { PlayerPrefs.SetInt("derevo", PlayerPrefs.GetInt("derevo") + 1); d = "derevo"; }

                this.gameObject.GetComponent<SpriteRenderer>().sprite = dont;
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, 0f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, 0f);
                if(resh == true)
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                else
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = false;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                if (SceneManager.GetActiveScene().buildIndex == 2)
                {
                    this.gameObject.GetComponent<ChangeColor>().go(nom, d, 1);
                }
                    GameObject.FindGameObjectWithTag("audio3").GetComponent<AudioSource>().Play();
                return;
            }
            else if (this.gameObject.GetComponent<FanceInfo>().YesOrNo == false)
            {
                PlayerPrefs.SetInt("musor", 0);
                GameObject.FindGameObjectWithTag("GameController").GetComponent<SpriteRenderer>().sprite = GameObject.FindGameObjectWithTag("GameController").GetComponent<Musorka>().chorsp;
                GameObject.FindGameObjectWithTag("GameController").GetComponent<Musorka>().udol = false;
                PlayerPrefs.SetString("brown1", "no");
                PlayerPrefs.SetString("red1", "no");
                PlayerPrefs.SetString("sir1", "no");
                PlayerPrefs.SetString("door1", "no");
                PlayerPrefs.SetString("tree1", "no");
                PlayerPrefs.SetString("flower1", "no");
                PlayerPrefs.SetString("kamin1", "no");
                PlayerPrefs.SetString("divan1", "no");
                PlayerPrefs.SetString("zabor1", "no");
                PlayerPrefs.SetString("tv1", "no");
                PlayerPrefs.SetString("stena1", "no");
                PlayerPrefs.SetString("phone1", "no");
                PlayerPrefs.SetString("table1", "no");
                PlayerPrefs.SetString("comp1", "no");
                PlayerPrefs.SetString("stenaGreen1", "no");
                PlayerPrefs.SetString("stenaBlue1", "no");
                PlayerPrefs.SetString("stenaFiol1", "no");
                PlayerPrefs.SetString("stenaRed1", "no");
                PlayerPrefs.SetString("stenaYeloww1", "no");
                PlayerPrefs.SetString("lampa1", "no");
                PlayerPrefs.SetString("bed1", "no");
                PlayerPrefs.SetString("shkaf1", "no");
                PlayerPrefs.SetString("tumb1", "no");
                PlayerPrefs.SetString("xolod1", "no");
                PlayerPrefs.SetString("aqua1", "no");
                PlayerPrefs.SetString("stiral1", "no");
                PlayerPrefs.SetString("vodop1", "no");
                PlayerPrefs.SetString("tualet1", "no");
                PlayerPrefs.SetString("vanna1", "no");
                PlayerPrefs.SetString("dog1", "no");
                PlayerPrefs.SetString("derevo1", "no");
                PlayerPrefs.SetString("cat1", "no");


            }
        }
    }
}
