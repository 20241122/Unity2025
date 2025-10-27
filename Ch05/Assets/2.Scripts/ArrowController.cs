using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //히트박스는 네모보다 원이 간단하다. 원의 r1, r2 거리보다 짧아지면 충돌된걸로 인식
    public float dropSpeed = 0.1f; //게임 난이도에  영향 줄수도
    public float arrowRadius = 0.3f;
    public float playerRadius = 0.7f;

    Transform playerTransform;

    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.Find("player").GetComponent<Transform>(); //player에 대한 오브젝트를 찾고 그에 대한 tansform을 찾아서 연결 시키는 것
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);
        if(transform.position.y < -7.0f)
        {
            Destroy(gameObject); //gameobject는 자기 자신을 가리킴
        }

        CheckCollision();
    }
    void CheckCollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float distance = (arrowPosition - playerPosition).magnitude; //변수를 소문자로 해야되는 이유...?
        //vector에 대한 개념

        //충돌 발생
        if (distance < arrowRadius + playerRadius) 
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>()
                .DecreaseHP();
       
            Destroy(gameObject);
        }
    }

}
