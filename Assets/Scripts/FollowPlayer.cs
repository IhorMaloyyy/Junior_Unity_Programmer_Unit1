using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 changeView = new Vector3(0, 1.8f, 1.05f);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frames
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
