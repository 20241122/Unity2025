using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomsongiGenerater : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 200f;
    float startValue;
    float power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startValue = Input.mousePosition.y;
        }

        if(Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startValue;

            GameObject go = Instantiate(bamsongiPrefab);
            go.transform.position = new Vector3(transform.position.x,
                transform.position.y + 1,
                transform.position.z + 1);

            go.GetComponent<BomsongiController>().Shoot(
            (transform.forward + transform.up * 0.5f) * throwForce * power);
        }
    }
}
