using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    public float dropSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);
        if(transform.position.y < -7.0f)
        {
            Destroy(gameObject); //gameobject는 자기 자신을 가리킴
        }
    }
}
