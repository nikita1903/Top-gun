using UnityEngine;
using UnityEngine.UI;

public class IgraVremya : MonoBehaviour
{
    public float timer = 300f;
    public bool vse = false;
    public bool instr;
    public int i = 0;
    public GameObject panel;
    public GameObject yyes;
    public Animation time;
    private void Start()
    {
        GetComponent<Animator>().speed = 0f;
    }
    void Update()
    {
        if (instr == true)
        {
            if (!vse)
            {
                timer += Time.deltaTime;
                GetComponentInChildren<Text>().text = (300 - System.Convert.ToInt32(timer)).ToString() + " sec";
                if (timer >= 290f)
                {
                    GetComponent<Animator>().speed = 1f;
                }
                if (timer >= 300f)
                {
                    if (GameObject.FindGameObjectWithTag("Respawn"))
                    {
                        GameObject.FindGameObjectWithTag("Respawn").SetActive(false);
                    }
                    GetComponent<Animator>().speed = 0f;
                    yyes.SendMessage("OnMouseUpAsButton");
                    GameObject.FindGameObjectWithTag("stop").GetComponent<Score>().MoN = true;
                    GameObject.FindGameObjectWithTag("stop").SendMessage("OnMouseUpAsButton");
                    vse = true;
                }
            }
        }
    }
}
