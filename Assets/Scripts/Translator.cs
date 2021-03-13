using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) return;
        if (PlayerPrefs.GetInt("Russia") == 1)
        {
            switch (gameObject.name)
            {
                case "Text":
                    gameObject.GetComponent<Text>().text = "Вы сможете строить когда второй игрок присоеденится";
                    break;
                case "TextOut":
                    gameObject.GetComponent<Text>().text = "Внешняя мебель";
                    break;
                case "TextFurn":
                    gameObject.GetComponent<Text>().text = "Мебель";
                    break;
                case "TextWalls":
                    gameObject.GetComponent<Text>().text = "Стены";
                    break;
            }
        }
     }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (PlayerPrefs.GetInt("Russia") == 1)
            {
                switch (gameObject.name)
                {
                    case "Textt":
                        gameObject.GetComponent<Text>().text = "Сетевая игра";
                        break;
                    case "TextSet":
                        if (gameObject.GetComponent<Text>().text == "Online")
                        {
                            gameObject.GetComponent<Text>().text = "В сети";
                        }
                        if (gameObject.GetComponent<Text>().text == "Offline")
                        {
                            gameObject.GetComponent<Text>().text = "Не в сети";
                        }
                        break;
                    case "TextCreateRoom":
                        gameObject.GetComponent<Text>().text = "Создать комнату";
                        break;
                    case "TextConnect":
                        gameObject.GetComponent<Text>().text = "Присоеденится к случайной комнате";
                        break;
                    case "TextConn":
                        gameObject.GetComponent<Text>().text = "Присоеденится к";
                        break;
                    case "Text":
                        if(gameObject.GetComponent<Text>().text == "enter the number")
                        gameObject.GetComponent<Text>().text = "Введите номер комнаты";
                        break;
                }
            }
            if (PlayerPrefs.GetInt("Russia") == 0)
            {
                switch (gameObject.name)
                {
                    case "Textt":
                        gameObject.GetComponent<Text>().text = "Multiplayer";
                        break;
                    case "TextSet":
                        if (gameObject.GetComponent<Text>().text == "В сети")
                        {
                            gameObject.GetComponent<Text>().text = "Online";
                        }
                        if (gameObject.GetComponent<Text>().text == "Не в сети")
                        {
                            gameObject.GetComponent<Text>().text = "Offline";
                        }
                        break;
                    case "TextCreateRoom":
                        gameObject.GetComponent<Text>().text = "Create room";
                        break;
                    case "TextConnect":
                        gameObject.GetComponent<Text>().text = "Connect to random room";
                        break;
                    case "TextConn":
                        gameObject.GetComponent<Text>().text = "Connect to";
                        break;
                    case "Text":
                        if (gameObject.GetComponent<Text>().text == "Введите номер комнаты")
                            gameObject.GetComponent<Text>().text = "enter the number";
                        break;
                }
            }
        }
    }
}
