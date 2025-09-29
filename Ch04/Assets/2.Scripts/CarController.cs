using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float decreaseRatio = 0.98f;
    public float speedRatio = 1000f;
    float speed = 0f;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //실행이 되는 프레임을 초당 60프레임으로 맞춰주겠다
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //this.speed = 0.2f;
            this.startPos = Input.mousePosition;
        } else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            this.speed = swipeLength/speedRatio;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); //Translate : 이동, speed 만큼 이동. y, z방향으로 이동 안 함
        this.speed *= decreaseRatio;
        if (this.speed < 0.01f) this.speed = 0f;

        Debug.Log("deltaTime : " + Time.deltaTime); //deltaTime이란? = 60분의 1(60프레임의 1)
    }
}
