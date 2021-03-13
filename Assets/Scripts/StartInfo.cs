using UnityEngine;
using UnityEngine.UI;

public class StartInfo : MonoBehaviour
{
    public GameObject panel;
    public GameObject[] TI;
    private int i = 0;
    private void Start()
    {
       panel.SetActive(true);
       GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
       if(PlayerPrefs.GetInt("Russia") == 1)
        {
            TI[0].GetComponentInChildren<Text>().text = "Продажа всех необходимых ресурсов";
            TI[1].GetComponentInChildren<Text>().text = "После постройки здания,нажмите на эту кнопку для его оценивания";
            TI[2].GetComponentInChildren<Text>().text = "Главный герой (строитель), которым вы управляете";
            TI[3].GetComponentInChildren<Text>().text = "Рюкзак, в котором хранятся строительные ресурсы";
            TI[4].GetComponentInChildren<Text>().text = "Кнопка, переворачивающая персонажа";
            TI[5].GetComponentInChildren<Text>().text = "Удаление обьектов обратно в инвентарь";
            TI[6].GetComponentInChildren<Text>().text = "Кнопка 1 управления персонажем";
            TI[7].GetComponentInChildren<Text>().text = "Кнопка 2 управления персонажем";
            TI[8].GetComponentInChildren<Text>().text = "Кнопка, показывающая границы постройки";
        }
    }
    private void OnMouseUpAsButton()
    {
        if(gameObject.name == "close")
        { panel.SetActive(false); GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None; GameObject.FindGameObjectWithTag("tumer").GetComponent<IgraVremya>().instr = true; return; }
        TI[i].SetActive(false);
        if (i == 8) { panel.SetActive(false); GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None; GameObject.FindGameObjectWithTag("tumer").GetComponent<IgraVremya>().instr = true; }
        i++;
        TI[i].SetActive(true);
    }
}
