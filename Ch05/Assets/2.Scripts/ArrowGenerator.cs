using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab; //public inspect에서 연계시키겠다.

    float span = 1.0f; //1초 간격
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //자기 자신에 계속 누적시킨다. //this : 로컬 변수가 아니고, 멤버? 변수다.

        if (this.delta > this.span)
        {
            this.delta = 0f; //this.delta 리셋
            GameObject go = Instantiate(arrowPrefab); //instantiate
            float px = Random.Range(-8.0f, 8.0f); //위치
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}
