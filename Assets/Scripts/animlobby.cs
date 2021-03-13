using UnityEngine;
using UnityEngine.UI;
public class animlobby : MonoBehaviour
{
    public GameObject play;
    public GameObject[] buttons;
    private bool kak = false;
    public GameObject teaxt;
    TouchScreenKeyboard lavie;
    private void OnMouseDown()
    {
        if (kak == false)
        {
            play.SetActive(false);
            for(int i = 0; i < 4; i++)
            {
                buttons[i].SetActive(true);
                buttons[i].GetComponent<Animation>().Play("BCreate");
            }
             teaxt.SetActive(true);
            kak = true;
            return;
        }
        else
        {
            play.SetActive(true);
            teaxt.SetActive(false);
            for (int i = 0; i < 4; i++)
            {
                buttons[i].SetActive(false);
            }
            kak = false;
            return;
        }
    }
    public void OpenKeyboard()
    {
        lavie = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad);
    }
    void Update()
    {
        if(TouchScreenKeyboard.visible == false && lavie != null)
        {
            this.gameObject.GetComponentInChildren<Text>().text = lavie.text;
            lavie = null;
        }
    }
}
