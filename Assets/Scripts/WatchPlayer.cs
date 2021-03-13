using UnityEngine;

public class WatchPlayer : MonoBehaviour
{
    public GameObject player;
    public bool stop;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        if (stop == false)
            transform.position = player.transform.position + offset;
    }
}
