using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraContrl : MonoBehaviour
{
    public GameObject player;
    public bool stop;
    private Vector3 offset;
    void Start()
    {
        
        offset = transform.position - player.transform.position;
        Debug.Log(gameObject.name + " offset = " + offset);
        string lname = SceneManager.GetActiveScene().name;
        if (lname == "SampleScene 1")
        {
            offset = new Vector3(-0.3f, 3.0f, -10f);
            if (gameObject.name == "perevman") offset = new Vector3(6.2f, 7.6f, 0f);
            if (gameObject.name == "chor") offset = new Vector3(7.9f, 7.5f, 0f);
            if (gameObject.name == "BackPack") offset = new Vector3(-6.2f, -0.1f, 0f);
        }
    }
    void LateUpdate()
    {
        if(stop == false)
        transform.position = player.transform.position + offset;
    }
}
