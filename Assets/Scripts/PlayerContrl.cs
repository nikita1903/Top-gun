using UnityEngine;
using UnityEngine.UI;
public class PlayerContrl : MonoBehaviour
{
    public float speed = 20f;
    public GameObject Haracter;
    private Rigidbody2D rb;
    public GameObject right;
    public GameObject left;
    public GameObject Shop;
    public GameObject panel;
    public GameObject stop;
    private GameObject panback;
    private GameObject perevx;
    private GameObject musorka;
    private bool lang;
    private float moveX;
    private Vector3 newPos = new Vector3(0,0,0);
    private int b = 0;
    private GameObject[] pip = new GameObject[5];
    private bool bi = false;
    private bool bi1 = false;
    void Start()
    {
        rb = Haracter.GetComponent<Rigidbody2D>();
        if (PlayerPrefs.GetInt("Russia") == 1) lang = true;
        if (PlayerPrefs.GetInt("music") == 1)
        {
            GameObject.FindGameObjectWithTag("audio1").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio2").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio3").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio4").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio5").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio6").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio7").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("audio8").GetComponent<AudioSource>().mute = true;
            GameObject.FindGameObjectWithTag("left").GetComponent<AudioSource>().mute = true;
            bi = true;
        }
        if(PlayerPrefs.GetInt("vid") == 4) { bi1 = true; }
        Debug.Log("Вызвался");
        PlayerPrefs.DeleteAll();
        if (bi1 == true) PlayerPrefs.SetInt("vid", 4);
        if (lang == true) PlayerPrefs.SetInt("Russia", 1);
        if (bi == true) PlayerPrefs.SetInt("music", 1);
        if (PlayerPrefs.GetInt("Russia") == 1) GameObject.FindGameObjectWithTag("havebalance").GetComponent<Text>().text = "Баланс: 300000" + "$";
        panback = GameObject.FindGameObjectWithTag("BackPack");
        perevx = GameObject.FindGameObjectWithTag("perevx");
        musorka = GameObject.FindGameObjectWithTag("GameController");
    }
    private void OnMouseUpAsButton()
    {
        if (gameObject.name == "perevman")
        {
            rb.GetComponent<Transform>().rotation = Quaternion.Euler(newPos);
            GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().perev = true;
        }
    }
    private void OnMouseDown()
    {
        if (gameObject.name == "right" || gameObject.name == "left")
        {
            b = 0;
        }
    }
    private void OnMouseOver()
    {
        if (b == 0)
        {
            if (gameObject.name == "right")
            {
                rb.MovePosition(rb.position + Vector2.right * 1 * speed * Time.deltaTime);
            }
            if (gameObject.name == "left")
            {
                rb.MovePosition(rb.position + Vector2.right * -1 * speed * Time.deltaTime);
            }
        }
    }
    private void OnMouseUp()
    {
        b = 1;
    }

    void OnTriggerEnter2D(Collider2D mycollision)
    {
        if (mycollision.gameObject.name == "dropbox")
        {
            if (GameObject.FindGameObjectWithTag("itoga"))
            {
                Debug.Log("вв");
                GameObject.FindGameObjectWithTag("itoga").SetActive(false);
            }
            Shop.SetActive(true);
            for (int i = 0; i <= 4; i++)
            {

                Shop.transform.GetChild(i).gameObject.SetActive(true);
                pip[i] = Shop.transform.GetChild(i).gameObject;
                Debug.Log(pip[i].name + " " +i);
            }
            for (int i = 2; i <= 4; i++)
            {
                for (int j = 0; j < pip[i].transform.childCount; j++) {
                    pip[i].transform.GetChild(j).gameObject.SetActive(false);
                        }
                pip[i].transform.GetChild(0).gameObject.SetActive(true);
                pip[i].transform.GetChild(1).gameObject.SetActive(true);
            }

                if (panel.activeInHierarchy)
            {
                panel.SetActive(false);
            }
            //GameObject.FindGameObjectWithTag("brownn").GetComponent<ShopControl>().SendMessage("Updating");
            /*for (int i = 1; i <= 13; i++)
            {
                GameObject.FindGameObjectWithTag("brownn" + i).GetComponent<ShopControl>().SendMessage("Updating");
            }*/
            stop.SetActive(false);
            panback.SetActive(false);
            perevx.SetActive(false);
            musorka.SetActive(false);
        }
        if (mycollision.gameObject.name == "barier")
        {
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(6, -122, 0f);
            GameObject.FindGameObjectWithTag("Player").transform.rotation = Quaternion.Euler(0, 0, 0);
            GameObject.FindGameObjectWithTag("Player").transform.localScale = new Vector3(38, 38, 1);
        }
        }
    void OnTriggerExit2D(Collider2D collision)
    {
        panback.SetActive(true);
        perevx.SetActive(true);
        for (int i = 0; i < Shop.transform.childCount; i++)
        {
            Shop.transform.GetChild(i).gameObject.SetActive(false);
        }
        Shop.SetActive(false);
        stop.SetActive(true);
        musorka.SetActive(true);
    }
}
