using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Vibor : MonoBehaviour
{
    public GameObject panel;
    public GameObject brown;
    public GameObject red;
     public GameObject sir;
     public GameObject stena;
  public GameObject door;
    public GameObject tree;
    public GameObject flower;
    public GameObject kamin;
     public GameObject divan;
    public GameObject zabor;
    public GameObject tv;
   public GameObject phone;
     public GameObject table;
     public GameObject comp;
     public GameObject stenaGreen;
    public GameObject stenaBlue;
 public GameObject stenaFiol;
     public GameObject stenaRed;
     public GameObject stenaYeloww;
     public GameObject lampa;
     public GameObject bed;
    public GameObject shkaf;
     public GameObject tumb;
    public GameObject xolod;
     public GameObject aqua;
     public GameObject stiral;
     public GameObject vodop;
     public GameObject tualet;
    public GameObject derevo;
    public GameObject vanna;
    public GameObject dog;
    public GameObject cat;
    public GameObject[] blocks;
    public Text info;
    public GameObject[] fanci;
    private float counter = 0;
    private static bool b = true;

    GameObject[] bee1;

    string[] bee = new string[] { "brown", "red", "sir", "stena", "door", "tree", "flower", "kamin", "divan", "zabor", "tv", "phone", "table", "comp", "stenaGreen", "stenaBlue", "stenaFiol", "stenaRed", "stenaYeloww", "lampa", "bed", "shkaf", "tumb", "xolod", "aqua", "stiral", "vodop", "tualet" };
 
    GameObject etot;
    private void Start()
    {   
        bee1 = new GameObject[] { brown, red, sir, stena, door, tree, flower, kamin, divan, zabor, tv, phone, table, comp, stenaGreen, stenaBlue, stenaFiol, stenaRed, stenaYeloww, lampa, bed, shkaf, tumb, xolod, aqua, stiral, vodop, tualet };
        fanci = GameObject.FindGameObjectsWithTag("Doski");
        
        if (PlayerPrefs.GetInt("Russia") == 1) { GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().info.text = "У вас нету ресурсов. Вы можете преобрести их в магазине, который находится в начале мира."; }
    }
    public void gotov()
    {
        Debug.Log("Выбор готов сроботал!11");
        if (gameObject.name == "BackPack")
        {
            if (!panel.activeInHierarchy)
            {
                if (GameObject.FindGameObjectWithTag("Respawn") || GameObject.FindGameObjectWithTag("itoga"))
                {
                    return;
                }
                panel.SetActive(true);
                panel.GetComponent<RectTransform>().localPosition = new Vector2(-2.4f, 65f);

            }
            else if (panel.activeInHierarchy)
            {
                panel.SetActive(false);
                for (int i = 0; i < fanci.Length; i++)
                {
                    fanci[i].GetComponent<MainScript>().mona = false;

                }
            }

        }
        if (panel.activeInHierarchy)
        {
            if (gameObject.name == "red" || gameObject.name == "kamin" || gameObject.name == "zabor" || gameObject.name == "table" || gameObject.name == "flower" || gameObject.name == "tv" || gameObject.name == "comp" || gameObject.name == "divan" || gameObject.name == "phone" || gameObject.name == "tree" || gameObject.name == "door" || gameObject.name == "stena" || gameObject.name == "brown" || gameObject.name == "sir" || gameObject.name == "red" || gameObject.name == "stenaGreen" || gameObject.name == "stenaFiol" || gameObject.name == "stenaRed" || gameObject.name == "stenaYeloww" || gameObject.name == "stenaBlue" || gameObject.name == "lampa" || gameObject.name == "bed" || gameObject.name == "shkaf" || gameObject.name == "tumb" || gameObject.name == "xolod" || gameObject.name == "aqua" || gameObject.name == "stiral" || gameObject.name == "vodop" || gameObject.name == "tualet" || gameObject.name == "vanna" || gameObject.name == "derevo" || gameObject.name == "dog" || gameObject.name == "cat")
            {
                Debug.Log("сюда  " + gameObject.name);
                for (int i = 0; i < fanci.Length; i++)
                {
                    fanci[i].GetComponent<MainScript>().mona = false;
                }
                counter = 0;
                PlayerPrefs.DeleteKey("red1");
                PlayerPrefs.DeleteKey("zabor1");
                PlayerPrefs.DeleteKey("table1");
                PlayerPrefs.DeleteKey("flower1");
                PlayerPrefs.DeleteKey("tv1");
                PlayerPrefs.DeleteKey("comp1");
                PlayerPrefs.DeleteKey("divan1");
                PlayerPrefs.DeleteKey("kamin1");
                PlayerPrefs.DeleteKey("phone1");
                PlayerPrefs.DeleteKey("tree1");
                PlayerPrefs.DeleteKey("door1");
                PlayerPrefs.DeleteKey("stena1");
                PlayerPrefs.DeleteKey("brown1");
                PlayerPrefs.DeleteKey("sir1");
                PlayerPrefs.DeleteKey("stenaGreen1");
                PlayerPrefs.DeleteKey("stenaFiol1");
                PlayerPrefs.DeleteKey("stenaRed1");
                PlayerPrefs.DeleteKey("stenaBlue1");
                PlayerPrefs.DeleteKey("stenaYeloww1");
                PlayerPrefs.DeleteKey("vodop1");
                PlayerPrefs.DeleteKey("lampa1");
                PlayerPrefs.DeleteKey("bed1");
                PlayerPrefs.DeleteKey("shkaf1");
                PlayerPrefs.DeleteKey("tumb1");
                PlayerPrefs.DeleteKey("xolod1");
                PlayerPrefs.DeleteKey("aqua1");
                PlayerPrefs.DeleteKey("stiral1");
                PlayerPrefs.DeleteKey("vodop1");
                PlayerPrefs.DeleteKey("tualet1");
                PlayerPrefs.DeleteKey("dog1");
                PlayerPrefs.DeleteKey("vanna1");
                PlayerPrefs.DeleteKey("derevo1");
                PlayerPrefs.DeleteKey("cat1");
                PlayerPrefs.SetString(gameObject.name + "1", "yes");
                if (PlayerPrefs.GetInt(gameObject.name) >= 1)
                {
                    Debug.Log("0");
                    panel.SetActive(false);
                    b = false;
                }
                /* while (counter < 10f)
                 {
                     break;
                     Debug.Log("1");
                     counter += Time.deltaTime;
                     if(counter >= 5f)
                     {
                         for (int i = 0; i < fanci.Length; i++)
                         {
                             fanci[i].GetComponent<MainScript>().mona = false;
                         }
                      break;
                     }
                 } */

            }
        }
    }
    public void OnMouseUpAsButton()
    {
        gotov();
    }
    private IEnumerator abv(float value)
    { 
       
        Debug.Log("1");
        yield return new WaitForSeconds(value);
            Debug.Log("2");
            for (int i = 0; i < fanci.Length; i++)
            {
                fanci[i].GetComponent<MainScript>().mona = true;
            }

    }
    private void Update()
    {
            if (gameObject.name == "BackPack")
            {
               
                if (b == false)
                {
                    StartCoroutine(abv(0.5f));
                    b = true;
                }
                if (panel.activeInHierarchy)
                {
                    int i = 0;
                    if (PlayerPrefs.GetInt("brown") >= 1) { brown.SetActive(true); brown.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; brown.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("brown").ToString(); }
                    if (PlayerPrefs.GetInt("red") >= 1) { red.SetActive(true); red.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; red.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("red").ToString(); }
                    if (PlayerPrefs.GetInt("sir") >= 1) { sir.SetActive(true); sir.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; sir.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("sir").ToString(); }
                    if (PlayerPrefs.GetInt("stena") >= 1) { stena.SetActive(true); stena.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stena.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stena").ToString(); }
                    if (PlayerPrefs.GetInt("door") >= 1) { door.SetActive(true); door.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); ; i++; door.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("door").ToString(); }
                    if (PlayerPrefs.GetInt("tree") >= 1) { tree.SetActive(true); tree.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; tree.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("tree").ToString(); }
                    if (PlayerPrefs.GetInt("flower") >= 1) { flower.SetActive(true); flower.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; flower.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("flower").ToString(); }
                    if (PlayerPrefs.GetInt("kamin") >= 1) { kamin.SetActive(true); kamin.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; kamin.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("kamin").ToString(); }
                    if (PlayerPrefs.GetInt("divan") >= 1) { divan.SetActive(true); divan.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; divan.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("divan").ToString(); }
                    if (PlayerPrefs.GetInt("zabor") >= 1) { zabor.SetActive(true); zabor.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; zabor.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("zabor").ToString(); }
                    if (PlayerPrefs.GetInt("tv") >= 1) { tv.SetActive(true); tv.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; tv.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("tv").ToString(); }
                    if (PlayerPrefs.GetInt("phone") >= 1) { phone.SetActive(true); phone.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; phone.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("phone").ToString(); }
                    if (PlayerPrefs.GetInt("table") >= 1) { table.SetActive(true); table.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; table.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("table").ToString(); }
                    if (PlayerPrefs.GetInt("comp") >= 1)
                    {
                        comp.SetActive(true);
                        comp.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; comp.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("comp").ToString();
                    }
                    if (PlayerPrefs.GetInt("stenaGreen") >= 1) { stenaGreen.SetActive(true); stenaGreen.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stenaGreen.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stenaGreen").ToString(); }
                    if (PlayerPrefs.GetInt("stenaBlue") >= 1) { stenaBlue.SetActive(true); stenaBlue.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stenaBlue.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stenaBlue").ToString(); }
                    if (PlayerPrefs.GetInt("stenaFiol") >= 1) { stenaFiol.SetActive(true); stenaFiol.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stenaFiol.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stenaFiol").ToString(); }
                    if (PlayerPrefs.GetInt("stenaRed") >= 1) { stenaRed.SetActive(true); stenaRed.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stenaRed.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stenaRed").ToString(); }
                    if (PlayerPrefs.GetInt("stenaYeloww") >= 1) { stenaYeloww.SetActive(true); stenaYeloww.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stenaYeloww.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stenaYeloww").ToString(); }
                    if (PlayerPrefs.GetInt("lampa") >= 1) { lampa.SetActive(true); lampa.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; lampa.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("lampa").ToString(); }
                    if (PlayerPrefs.GetInt("bed") >= 1) { bed.SetActive(true); bed.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; bed.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("bed").ToString(); }
                    if (PlayerPrefs.GetInt("shkaf") >= 1) { shkaf.SetActive(true); shkaf.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; shkaf.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("shkaf").ToString(); }
                    if (PlayerPrefs.GetInt("tumb") >= 1) { tumb.SetActive(true); tumb.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; tumb.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("tumb").ToString(); }
                    if (PlayerPrefs.GetInt("xolod") >= 1) { xolod.SetActive(true); xolod.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; xolod.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("xolod").ToString(); }
                    if (PlayerPrefs.GetInt("aqua") >= 1) { aqua.SetActive(true); aqua.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; aqua.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("aqua").ToString(); }
                    if (PlayerPrefs.GetInt("stiral") >= 1) { stiral.SetActive(true); stiral.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; stiral.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("stiral").ToString(); }
                    if (PlayerPrefs.GetInt("vodop") >= 1) { vodop.SetActive(true); vodop.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; vodop.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("vodop").ToString(); }
                    if (PlayerPrefs.GetInt("tualet") >= 1) { tualet.SetActive(true); tualet.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; tualet.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("tualet").ToString(); }
                if (PlayerPrefs.GetInt("vanna") >= 1) { vanna.SetActive(true); vanna.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; vanna.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("vanna").ToString(); }
                if (PlayerPrefs.GetInt("derevo") >= 1) { derevo.SetActive(true); derevo.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; derevo.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("derevo").ToString(); }
                if (PlayerPrefs.GetInt("dog") >= 1) { dog.SetActive(true); dog.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; dog.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("dog").ToString(); }
                if (PlayerPrefs.GetInt("cat") >= 1) { cat.SetActive(true); cat.transform.position = new Vector3(blocks[i].transform.position.x, blocks[i].transform.position.y, 0); i++; cat.GetComponentInChildren<Text>().text = PlayerPrefs.GetInt("cat").ToString(); }

                if (PlayerPrefs.GetInt("brown") < 1) brown.SetActive(false);
                    if (PlayerPrefs.GetInt("red") < 1) red.SetActive(false);
                    if
                    (PlayerPrefs.GetInt("sir") < 1) sir.SetActive(false);
                    if (PlayerPrefs.GetInt("stena") < 1) stena.SetActive(false);
                    if (PlayerPrefs.GetInt("door") < 1) door.SetActive(false);
                    if (PlayerPrefs.GetInt("tree") < 1) tree.SetActive(false);
                    if (PlayerPrefs.GetInt("flower") < 1) flower.SetActive(false);
                    if (PlayerPrefs.GetInt("kamin") < 1) kamin.SetActive(false);
                    if (PlayerPrefs.GetInt("divan") < 1) divan.SetActive(false);
                    if (PlayerPrefs.GetInt("zabor") < 1) zabor.SetActive(false);
                    if (PlayerPrefs.GetInt("tv") < 1) tv.SetActive(false);
                    if (PlayerPrefs.GetInt("phone") < 1) phone.SetActive(false);
                    if (PlayerPrefs.GetInt("table") < 1) table.SetActive(false);
                    if (PlayerPrefs.GetInt("comp") < 1) comp.SetActive(false);
                    if (PlayerPrefs.GetInt("stenaGreen") < 1) stenaGreen.SetActive(false);
                    if (PlayerPrefs.GetInt("stenaBlue") < 1) stenaBlue.SetActive(false);
                    if (PlayerPrefs.GetInt("stenaFiol") < 1) stenaFiol.SetActive(false);
                    if (PlayerPrefs.GetInt("stenaRed") < 1) stenaRed.SetActive(false);
                    if (PlayerPrefs.GetInt("stenaYeloww") < 1) stenaYeloww.SetActive(false);
                    if (PlayerPrefs.GetInt("lampa") < 1) lampa.SetActive(false);
                    if (PlayerPrefs.GetInt("bed") < 1) bed.SetActive(false);
                    if (PlayerPrefs.GetInt("shkaf") < 1) shkaf.SetActive(false);
                    if (PlayerPrefs.GetInt("tumb") < 1) tumb.SetActive(false);
                    if (PlayerPrefs.GetInt("xolod") < 1) xolod.SetActive(false);
                    if (PlayerPrefs.GetInt("aqua") < 1) aqua.SetActive(false);
                    if (PlayerPrefs.GetInt("stiral") < 1) stiral.SetActive(false);
                    if (PlayerPrefs.GetInt("vodop") < 1) vodop.SetActive(false);
                    if (PlayerPrefs.GetInt("tualet") < 1) tualet.SetActive(false);
                if (PlayerPrefs.GetInt("vanna") < 1) vanna.SetActive(false);
                if (PlayerPrefs.GetInt("derevo") < 1) derevo.SetActive(false);
                if (PlayerPrefs.GetInt("cat") < 1) cat.SetActive(false);
                if (PlayerPrefs.GetInt("dog") < 1) dog.SetActive(false);

                if (i == 0)
                    {
                        info.gameObject.SetActive(true);
                        brown.SetActive(false);
                        red.SetActive(false);
                        sir.SetActive(false);
                        stena.SetActive(false);
                        door.SetActive(false);
                        tree.SetActive(false);
                        flower.SetActive(false);
                        kamin.SetActive(false);
                        divan.SetActive(false);
                        zabor.SetActive(false);
                        tv.SetActive(false);
                        phone.SetActive(false);
                        table.SetActive(false);
                        comp.SetActive(false);
                        stenaGreen.SetActive(false);
                        stenaBlue.SetActive(false);
                        stenaFiol.SetActive(false);
                        stenaRed.SetActive(false);
                        stenaYeloww.SetActive(false);
                        lampa.SetActive(false);
                        bed.SetActive(false);
                        shkaf.SetActive(false);
                        tumb.SetActive(false);
                        xolod.SetActive(false);
                        aqua.SetActive(false);
                        stiral.SetActive(false);
                        vodop.SetActive(false);
                        tualet.SetActive(false);
                        vanna.SetActive(false);
                    dog.SetActive(false);
                    cat.SetActive(false);
                    derevo.SetActive(false);

                }
                if (i > 0) info.gameObject.SetActive(false);
                }
            }
    }
}
