using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab; //public inspect���� �����Ű�ڴ�.

    float span = 1.0f; //1�� ����
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //�ڱ� �ڽſ� ��� ������Ų��. //this : ���� ������ �ƴϰ�, ���? ������.

        if (this.delta > this.span)
        {
            this.delta = 0f; //this.delta ����
            GameObject go = Instantiate(arrowPrefab); //instantiate
            float px = Random.Range(-8.0f, 8.0f); //��ġ
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
