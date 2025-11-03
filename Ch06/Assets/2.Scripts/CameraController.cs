using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform playerTransform;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = this.playerTransform.position;
        transform.position = new Vector3(transform.position.x,
            PlayerPos.y + 2,
            transform.position.z);
    }

}
