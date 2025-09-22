using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 10.0f; //0.0�� �ȵǴ� ����. ����� �� (8����Ʈ, �÷�Ʈ�� 4����Ʈ)
    float startSpeed = 20.0f;
    float dRatio = 0.995f;
    float minSpeed = 0.1f; // �տ� public�� ������ ����Ƽ�� �Ķ���Ͱ� ��. ����� ������ ������?
    bool startDecrease = false;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //input�� ��
        {
            this.rotSpeed = this.startSpeed;
        }

        if (Input.GetMouseButtonUp(0))
        {
            this.startDecrease = true;
        }

        transform.Rotate(0, 0, -rotSpeed); //�� z������ ���ƾ��ϴ°�

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
