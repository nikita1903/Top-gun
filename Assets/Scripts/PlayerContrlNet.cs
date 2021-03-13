using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class PlayerContrlNet : MonoBehaviourPunCallbacks
{
    public float speed = 20f;
    public GameObject Haracter;
    private Rigidbody2D rb;
    private GameObject right;
    private GameObject left;
    public GameObject Shop;
    public GameObject panel;
    public GameObject[] fancis;
    public Sprite standart;
    private GameObject stop;
    public GameObject panback;
    private GameObject perevx;
    private GameObject musorka;
    private bool lang;
    private float moveX;
    private Vector3 newPos = new Vector3(0, 0, 0);
    private int b = 0;
    private PhotonView photonViewa;
    private GameObject textnet;

    public GameObject har1;
    public GameObject har2;

    public GameObject[] kon;

    public int chiv = 0;

    public int nomer = -1;

    public int bil = 0;

    private bool bi = false;
        void Start()
    {
       if (gameObject.tag == "Player")
        {
            fancis = GameObject.FindGameObjectsWithTag("Doski");
        }
        stop = GameObject.FindGameObjectWithTag("stop");
        photonViewa = GetComponent<PhotonView>();
        panback = GameObject.FindGameObjectWithTag("BackPack");
       
        right = GameObject.FindGameObjectWithTag("right");
        left = GameObject.FindGameObjectWithTag("left");
        rb = Haracter.GetComponent<Rigidbody2D>();
        if (PlayerPrefs.GetInt("Russia") == 1) lang = true;
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (GameObject.FindGameObjectWithTag("nada").GetComponent<Text>().text == "" && PlayerPrefs.GetString("nameRoom") != "")
            {
                if(PlayerPrefs.GetInt("Russia") == 1) 
                GameObject.FindGameObjectWithTag("nada").GetComponent<Text>().text = "Комната номер " + PlayerPrefs.GetString("nameRoom");
                else
                    GameObject.FindGameObjectWithTag("nada").GetComponent<Text>().text = "Room number " + PlayerPrefs.GetString("nameRoom");
            }
        }
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
        

        PlayerPrefs.DeleteAll();   PlayerPrefs.SetInt("balance", 300000);
        if (bi == true) PlayerPrefs.SetInt("music", 1);
        if (lang == true) PlayerPrefs.SetInt("Russia", 1);
        if (PlayerPrefs.GetInt("Russia") == 1) GameObject.FindGameObjectWithTag("havebalance").GetComponent<Text>().text = "Баланс: 300000" +"$";
        panback = GameObject.FindGameObjectWithTag("BackPack");
        perevx = GameObject.FindGameObjectWithTag("perevx");
        musorka = GameObject.FindGameObjectWithTag("GameController");
//}     
        if (photonViewa.Owner.IsLocal)
        {
            //this.gameObject.GetComponent<PlayerContrlNet>().fanci = PhotonNetwork.Instantiate(fanci.name, new Vector2(19.19745f, -0.9369488f), Quaternion.identity);
            //this.gameObject.GetComponent<PlayerContrlNet>().fanci.transform.Find("fence").GetComponent<MainScript>().mona = true;
            //  for (int i = 1; i < 192; i++)
            //   {
            //      this.gameObject.GetComponent<PlayerContrlNet>().fanci.transform.Find("fence (" + i + ")").GetComponent<MainScript>().mona = true;
            //  }
            this.gameObject.GetComponent<PlayerContrlNet>().textnet = GameObject.FindGameObjectWithTag("baton");
            Debug.Log("успех!!!");
            this.gameObject.GetComponent<PlayerContrlNet>().Shop = Instantiate(Shop, new Vector2(-2.4f, -2.1f), Quaternion.identity);
            this.gameObject.GetComponent<PlayerContrlNet>().Shop.GetComponent<RectTransform>().offsetMin = new Vector2(-2.4f, 150f);
            this.gameObject.GetComponent<PlayerContrlNet>().Shop.GetComponent<RectTransform>().offsetMax = new Vector2(2.3f, 0f);
            Debug.Log("Прогресс - 1");
            this.gameObject.GetComponent<PlayerContrlNet>().panel = Instantiate(panel, new Vector2(-2.4f, -2.1f), Quaternion.identity);
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().panel = this.gameObject.GetComponent<PlayerContrlNet>().panel;
            Debug.Log("Прогресс - 2");
            this.gameObject.GetComponent<PlayerContrlNet>().Shop.SetActive(false);
            this.gameObject.GetComponent<PlayerContrlNet>().panel.SetActive(false);
            this.gameObject.GetComponent<PlayerContrlNet>().Shop.GetComponent<Transform>().SetParent(GameObject.FindGameObjectWithTag("glcan").GetComponent<Transform>().transform, false);
            this.gameObject.GetComponent<PlayerContrlNet>().panel.GetComponent<Transform>().SetParent(GameObject.FindGameObjectWithTag("glcan").GetComponent<Transform>().transform, false);
            Debug.Log("Прогресс - 3");
            // началось фигня
   
            this.gameObject.GetComponent<PlayerContrlNet>().panel.SetActive(true);
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().brown = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("brown").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().red = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("red").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().sir = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("sir").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stena = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stena").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().door = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("door").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().tree = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("tree").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().flower = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("flower").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().kamin = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("kamin").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().divan = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("divan").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().zabor = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("zabor").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().tv = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("tv").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().phone = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("phone").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().table = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("table").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().comp = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("comp").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stenaGreen = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stenaGreen").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stenaBlue = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stenaBlue").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stenaFiol = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stenaFiol").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stenaRed = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stenaRed").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stenaYeloww = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stenaYeloww").gameObject;

            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().lampa = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("lampa").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().bed = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("bed").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().shkaf = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("shkaf").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().tumb = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("tumb").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().xolod = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("xolod").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().aqua = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("aqua").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().stiral = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("stiral").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().vodop = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("vodop").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().tualet = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("tualet").gameObject;

            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().vanna = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("vanna").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().derevo = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("derevo").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().cat = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("cat").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().dog = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("dog").gameObject;

            var sas = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("Scrool").gameObject;
            var sas1 = sas.transform.Find("blocks").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[0] = sas1.transform.Find("block1").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[1] = sas1.transform.Find("block2").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[2] = sas1.transform.Find("block3").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[3] = sas1.transform.Find("block4").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[4] = sas1.transform.Find("block5").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[5] = sas1.transform.Find("block6").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[6] = sas1.transform.Find("block7").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[7] = sas1.transform.Find("block8").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[8] = sas1.transform.Find("block9").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[9] = sas1.transform.Find("block10").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[10] = sas1.transform.Find("block11").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[11] = sas1.transform.Find("block12").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[12] = sas1.transform.Find("block13").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[13] = sas1.transform.Find("block14").gameObject;

            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[14] = sas1.transform.Find("block1 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[15] = sas1.transform.Find("block2 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[16] = sas1.transform.Find("block3 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[17] = sas1.transform.Find("block4 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[18] = sas1.transform.Find("block5 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[19] = sas1.transform.Find("block6 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[20] = sas1.transform.Find("block7 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[21] = sas1.transform.Find("block8 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[22] = sas1.transform.Find("block9 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[23] = sas1.transform.Find("block10 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[24] = sas1.transform.Find("block11 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[25] = sas1.transform.Find("block12 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[26] = sas1.transform.Find("block13 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[27] = sas1.transform.Find("block14 (1)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[28] = sas1.transform.Find("block11 (2)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[29] = sas1.transform.Find("block12 (2)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[30] = sas1.transform.Find("block13 (2)").gameObject;
            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().blocks[31] = sas1.transform.Find("block14 (2)").gameObject;

            GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().info = this.gameObject.GetComponent<PlayerContrlNet>().panel.transform.Find("Text").gameObject.GetComponentInChildren<Text>();
            if (PlayerPrefs.GetInt("Russia") == 1) { GameObject.FindGameObjectWithTag("BackPack").GetComponent<Vibor>().info.text = "У вас нету ресурсов. Вы можете преобрести их в магазине, который находится в начале мира."; }

            this.gameObject.GetComponent<PlayerContrlNet>().panel.SetActive(false);
            // закончилось фигня
            Debug.Log("Прогресс - 4");
            Camera.main.GetComponent<CameraContrl>().player = gameObject;
            right.GetComponent<PlayerContrlNet>().Haracter = this.gameObject;
            left.GetComponent<PlayerContrlNet>().Haracter = this.gameObject;
            GameObject.FindGameObjectWithTag("perevx").GetComponent<CameraContrl>().player = this.gameObject;
           GameObject.FindGameObjectWithTag("perevx").GetComponent<PlayerContrlNet>().Haracter = this.gameObject;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<CameraContrl>().player = this.gameObject;
        }
    }
    /*private void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            for (int i = 0; i < fancis.Length; i++)
            {
                if (fancis[i].GetComponent<SpriteRenderer>().sprite != standart)
                {
                    GameObject thiss = fancis[i];
                    GameObject[] now = GameObject.FindGameObjectsWithTag("Player");
                    now[0].GetComponent<PlayerContrlNet>().fancis[i] = thiss;
                    now[1].GetComponent<PlayerContrlNet>().fancis[i] = thiss;
                }
            }
        }
    }*/
    private void OnMouseUpAsButton()
    {
      // if (!photonViewa.IsMine) return;
            if (gameObject.name == "perevman")
        {
            GameObject.FindGameObjectWithTag("perevx").GetComponent<PlayerContrlNet>().Haracter.GetComponent<Transform>().rotation = Quaternion.Euler(newPos);
          //  rb.GetComponent<Transform>().rotation = Quaternion.Euler(newPos);
            GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().perev = true;
        }
    }
    private void OnMouseDown()
    {
       // if (!photonViewa.IsMine)
        //{
          //  return;
        //}
        if (gameObject.name == "right" || gameObject.name == "left")
        {
            b = 0;
        }
    }
    private void OnMouseOver()
    {
     // if (!photonViewa.IsMine) return, Debug.Log("не удачно");
            if (b == 0)
            {

                if (gameObject.tag == "right")
                {

                GameObject.FindGameObjectWithTag("right").GetComponent<PlayerContrlNet>().Haracter.GetComponent<Rigidbody2D>().MovePosition(GameObject.FindGameObjectWithTag("right").GetComponent<PlayerContrlNet>().Haracter.GetComponent<Rigidbody2D>().position + Vector2.right * 1 * speed * Time.deltaTime);
               }
                if (gameObject.tag == "left")
                {
                GameObject.FindGameObjectWithTag("right").GetComponent<PlayerContrlNet>().Haracter.GetComponent<Rigidbody2D>().MovePosition(GameObject.FindGameObjectWithTag("right").GetComponent<PlayerContrlNet>().Haracter.GetComponent<Rigidbody2D>().position + Vector2.right * -1 * speed * Time.deltaTime);
                }
            }
    }
    private void OnMouseUp()
    {
      //  if (!photonViewa.IsMine) return;
        b = 1;
    }

    void OnTriggerEnter2D(Collider2D mycollision)
    {
        if (mycollision.gameObject.name == "dropbox")
        {

            //GameObject b = PhotonNetwork.InstantiateRoomObject(Shop.name, new Vector2(-2.4f,-2.1f), Quaternion.identity);
            //  GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerContrlNet>().Shop = b;
            if (GameObject.FindGameObjectWithTag("itoga"))
            {
                Debug.Log("вв");
                GameObject.FindGameObjectWithTag("itoga").SetActive(false);
            }
            Shop.SetActive(true);

            if (panel.activeInHierarchy)
            {
                panel.SetActive(false);
            }
           // GameObject.FindGameObjectWithTag("brownn").GetComponent<ShopControl>().SendMessage("Updating");
            //for (int i = 1; i <= 13; i++)
            //{
           //     GameObject.FindGameObjectWithTag("brownn" + i).GetComponent<ShopControl>().SendMessage("Updating");
            //}
           /* stop.SetActive(false);
            panback.SetActive(false);
            perevx.SetActive(false);
            musorka.SetActive(false);*/
         //   textnet.SetActive(false);
        }
        if (mycollision.gameObject.name == "barier")
        {
            GameObject.FindGameObjectWithTag("right").GetComponent<PlayerContrlNet>().Haracter.transform.localPosition = new Vector3(6, -3.820533f, 0f);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "dropbox")
        {
//            textnet.SetActive(true);
            panback.SetActive(true);
            perevx.SetActive(true);
            Shop.SetActive(false);
            stop.SetActive(true);
            musorka.SetActive(true);
        }
    }
}
