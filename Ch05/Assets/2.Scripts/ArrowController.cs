using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //��Ʈ�ڽ��� �׸𺸴� ���� �����ϴ�. ���� r1, r2 �Ÿ����� ª������ �浹�Ȱɷ� �ν�
    public float dropSpeed = 0.1f; //���� ���̵���  ���� �ټ���
    public float arrowRadius = 0.3f;
    public float playerRadius = 0.7f;

    Transform playerTransform;

    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.Find("player").GetComponent<Transform>(); //player�� ���� ������Ʈ�� ã�� �׿� ���� tansform�� ã�Ƽ� ���� ��Ű�� ��
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -dropSpeed, 0);
        if(transform.position.y < -7.0f)
        {
            Destroy(gameObject); //gameobject�� �ڱ� �ڽ��� ����Ŵ
        }

        CheckCollision();
    }
    void CheckCollision()
    {
        Vector2 arrowPosition = transform.position;
        Vector2 playerPosition = playerTransform.position;
        float distance = (arrowPosition - playerPosition).magnitude; //������ �ҹ��ڷ� �ؾߵǴ� ����...?
        //vector�� ���� ����

        //�浹 �߻�
        if (distance < arrowRadius + playerRadius) 
        {
            Destroy(gameObject);
        }
    }

}
