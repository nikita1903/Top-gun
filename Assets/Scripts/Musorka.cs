using UnityEngine;

public class Musorka : MonoBehaviour
{
    public GameObject chor;
    public Sprite kr;
    public Sprite chorsp;
    public static int musor;
    public bool udol = false;
    public void OnMouseUpAsButton()
    {
        if (gameObject.name == "chor" && gameObject.tag == "GameController")
        {
            if (udol == false)
            {
                chor.GetComponent<SpriteRenderer>().sprite = kr;
                udol = true;
                PlayerPrefs.SetInt("musor", 1);
                return;
            }
            else if(udol == true)
            {
                chor.GetComponent<SpriteRenderer>().sprite = chorsp;
                udol = false;
                PlayerPrefs.SetInt("musor", 0);
                return;
            }
        }
    }
}
