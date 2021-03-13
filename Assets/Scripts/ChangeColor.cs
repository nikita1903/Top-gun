using UnityEngine;
using Photon.Pun;

public class ChangeColor : MonoBehaviourPunCallbacks
{
    private PhotonView myPV;
    public Sprite standart;
    private Sprite vot;
    private bool isntStandart;

    public GameObject[] fance;

    private bool brown1;
    private bool red1;
    private bool sir1;
    private bool stena1;
    private bool door11;
    private bool door21;
    private bool tree1;
    private bool flower1;
    private bool kamin1;
    private bool divan1;
    private bool zabor1;
    private bool tv1;
    private bool phone1;
    private bool table1;
    private bool comp1;

    private bool stenaGreen1;
    private bool stenaBlue1;
    private bool stenaFiol1;
    private bool stenaRed1;
    private bool stenaYeloww1;
    private bool lampa1;
    private bool bed1;
    private bool shkaf1;
    private bool tumb1;
    private bool xolod1;
    private bool aqua1;
    private bool stiral1;
    private bool vodop1;
    private bool tualet1;

    private bool vanna1;
    private bool derevo1;
    private bool cat1;
    private bool dog1;

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
    public Sprite cat;
    public Sprite dog;
    public Sprite vanna;

    public Sprite dont;

    private GameObject nomer;

    private PhotonView pv;

    private void Start()
    {
        fance = GameObject.FindGameObjectsWithTag("Doski");
        pv = GetComponent<PhotonView>();
       
    }
    public void go(int fenc, string chvet, int mus)
    {
         pv.RPC("ChangeColorToRed", RpcTarget.All, fenc, chvet, mus);
    }

    [PunRPC]
    public void ChangeColorToRed(int fanc, string chvet, int mus)
    {
        if (mus == 0)
        {
            if (chvet == "brown")
            {
                brown1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "red")
            {
                red1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "sir")
            {
                sir1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stena")
            {
                stena1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "door1")
            {
                door11 = true;
                door21 = true;
                nomer = fance[fanc];
            }
            if (chvet == "tree")
            {
                tree1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "flower")
            {
                flower1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "kamin")
            {
                kamin1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "divan")
            {
                divan1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "zabor")
            {
                zabor1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "tv")
            {
                tv1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "phone")
            {
                phone1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "table")
            {
                table1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "comp")
            {
                comp1 = true;
                nomer = fance[fanc];
            }
            if(chvet == "stenaGreen")
            {
                stenaGreen1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stenaBlue")
            {
                stenaBlue1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stenaFiol")
            {
                stenaFiol1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stenaRed")
            {
                stenaRed1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stenaYeloww")
            {
                stenaYeloww1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "lampa")
            {
                lampa1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "bed")
            {
                bed1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "shkaf")
            {
                shkaf1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "tumb")
            {
                tumb1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "xolod")
            {
                xolod1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "aqua")
            {
                aqua1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "stiral")
            {
                stiral1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "vodop")
            {
                vodop1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "tualet")
            {
                tualet1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "cat")
            {
                cat1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "dog")
            {
                dog1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "derevo")
            {
                derevo1 = true;
                nomer = fance[fanc];
            }
            if (chvet == "vanna")
            {
                vanna1 = true;
                nomer = fance[fanc];
            }
            if (brown1)
            {
                Debug.Log("2: " + this.gameObject.name);

                this.gameObject.GetComponent<SpriteRenderer>().sprite = brown;
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().brown += 1;

            }
            if (red1)
            {
                Debug.Log("2: " + this.gameObject.name);

                this.gameObject.GetComponent<SpriteRenderer>().sprite = red; this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().red += 1;

            }
            if (sir1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sir; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().sir += 1;
            }
            if (stena1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (door11)
            {
                float etotY = this.gameObject.GetComponent<Transform>().position.y;
                float etotX = this.gameObject.GetComponent<Transform>().position.x;
                float sledY;
                for (int i = 0; i < fance.Length; i++)
                {
                    sledY = fance[i].GetComponent<Transform>().position.y;
                    float eto = sledY - etotY;
                    float sledX = fance[i].GetComponent<Transform>().position.x;
                    if (eto == 1.0f && sledX == etotX && fance[i].GetComponent<SpriteRenderer>().sprite == dont)
                    {
                        fance[i].GetComponent<SpriteRenderer>().sprite = door1;
                        fance[i].GetComponent<FanceInfo>().YesOrNo = true;
                        fance[i].GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                        break;
                    }
                }
                this.gameObject.GetComponent<SpriteRenderer>().sprite = door2;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().door += 1;
            }
            if (tree1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = tree; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tree += 1;

            }
            if (flower1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = flower; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().flower += 1;

            }
            if (kamin1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = kamin; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().kamin += 1;

            }
            if (divan1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = divan; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().divan += 1;
            }
            if (zabor1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = zabor; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().zabor += 1;

            }
            if (tv1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = tv; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tv += 1;

            }
            if (phone1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = phone; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().phone += 1;

            }
            if (table1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = table; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().table += 1;
            }
            if (comp1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = comp; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().comp += 1;

            }
            if (stenaGreen1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.25f, 0.9f, 0.3f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (stenaBlue1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.348f, 0.9f, 0.993f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false; GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (stenaFiol1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0.5720f, 0.1273f, 1f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false; GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (stenaRed1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 0.2f, 0f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false; GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (stenaYeloww1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stena; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 0.9766f, 0f);
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false; GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stena += 1;
            }
            if (lampa1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = lampa; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().lampa += 1;

            }
            if (bed1)
            {
                this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0f, -0.18f);
                this.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 0.49f);
                this.gameObject.GetComponent<SpriteRenderer>().sprite = bed; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().bed += 1;

            }
            if (shkaf1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = shkaf; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().shkaf += 1;

            }
            if (tumb1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = tumb; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tumb += 1;

            }
            if (xolod1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = xolod; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().xolod += 1;

            }
            if (aqua1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = aqua; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().aqua += 1;

            }
            if (stiral1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = stiral; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().stiral += 1;

            }
            if (vodop1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vodop; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().vodop += 1;

            }
            if (tualet1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = tualet; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().tualet += 1;

            }
            if (dog1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = dog; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().dog += 1;

            }
            if (cat1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = cat; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().cat += 1;

            }
            if (vanna1)
            { 
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vanna; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().vanna += 1;

            }
            if (derevo1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = derevo; Debug.Log("2: " + this.gameObject.name);
                this.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1f);
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = true; this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().derevo += 1;

            }
        }
        if(mus == 1)
        {
            if(chvet == "door1")
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = dont;
                this.gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y, 0f);
                if (this.gameObject.GetComponent<MainScript>().resh == true)
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                else
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
               // this.gameObject.GetComponent<SpriteRenderer>().color = GameObject.FindGameObjectWithTag("Doski").GetComponent<SpriteRenderer>().color;
                this.gameObject.GetComponent<FanceInfo>().YesOrNo = false;
                this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                GameObject.FindGameObjectWithTag("audio3").GetComponent<AudioSource>().Play();
                float etotY = this.gameObject.GetComponent<Transform>().position.y;
                float etotX = this.gameObject.GetComponent<Transform>().position.x;
                float sledY;
                for (int i = 0; i < fance.Length; i++)
                {
                    sledY = fance[i].GetComponent<Transform>().position.y;
                    float eto = sledY - etotY;
                    float sledX = fance[i].GetComponent<Transform>().position.x;
                    if (eto == 1.0f && sledX == etotX)
                    {
                        fance[i].gameObject.GetComponent<Transform>().position = new Vector3(fance[i].transform.position.x, fance[i].transform.position.y, 0f);
                        fance[i].gameObject.GetComponent<SpriteRenderer>().sprite = dont;
                        if (fance[i].gameObject.GetComponent<MainScript>().resh == true)
                            fance[i].gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                        else
                            fance[i].gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
                        
                        fance[i].gameObject.GetComponent<FanceInfo>().YesOrNo = false;
                        fance[i].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                        break;
                    }
                }
                return;
            }
            
        }
        if (mus == 2)
        {
            for (int i = 0; i < fance.Length; i++)
            {
                fance[i].GetComponent<BoxCollider2D>().offset = new Vector2(0f, 0f);
                fance[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                fance[i].GetComponent<SpriteRenderer>().sprite = dont;
                if (fance[i].GetComponent<MainScript>().resh == true)
                    fance[i].GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                else
                    fance[i].GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
                fance[i].GetComponent<FanceInfo>().YesOrNo = false;
                fance[i].GetComponent<BoxCollider2D>().isTrigger = true;
            }
        }
        }
}
