using UnityEngine;

public class FanceScript : MonoBehaviour
{
    private GameObject[] fances;
    private void Start()
    {
        fances = GameObject.FindGameObjectsWithTag("Doski");
    }
    private void OnMouseUpAsButton()
    {
        if (gameObject.name == "inter-fances")
        {
            GetComponent<AudioSource>().Play();
            Color d = new Color(0, 0, 0, 0f);
            for (int i = 0; i < fances.Length; i++)
            {
                if (fances[i].GetComponent<SpriteRenderer>().color == d && fances[i].GetComponent<FanceInfo>().YesOrNo == false)
                {
                    fances[i].GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1f);
                    
                }
                else if (fances[i].GetComponent<SpriteRenderer>().color != d && fances[i].GetComponent<FanceInfo>().YesOrNo == false)
                {
                    fances[i].GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);
                    
                }
            }
            for (int i = 0; i < fances.Length; i++)
            {
                if (fances[i].GetComponent<MainScript>().resh == false) {
                    fances[i].GetComponent<MainScript>().resh = true;
                    continue;
                        }
                if(fances[i].GetComponent<MainScript>().resh == true)
                    fances[i].GetComponent<MainScript>().resh = false;
            }
         }
    }
}
