using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float dropSpeed = -1.5f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
