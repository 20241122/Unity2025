using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 10.0f; //0.0은 안되는 이유. 더블로 됨 (8바이트, 플로트는 4바이트)
    float startSpeed = 20.0f;
    float dRatio = 0.995f;
    float minSpeed = 0.1f; // 앞에 public을 넣으면 유니티에 파라미터가 뜸. 디버깅 용으로 좋은듯?
    bool startDecrease = false;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //input의 뜻
        {
            this.rotSpeed = this.startSpeed;
        }

        if (Input.GetMouseButtonUp(0))
        {
            this.startDecrease = true;
        }

        transform.Rotate(0, 0, -rotSpeed); //왜 z축으로 돌아야하는가

        if(this.startDecrease)
        {
            this.rotSpeed *= this.dRatio;
        }

        if(this.rotSpeed < this.minSpeed)
        {
            this.rotSpeed = 0f;
        }
    }
}
