using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 목표: 아래 방향으로 이동한다.
// 목표2: 다른 충돌체와 부딪혔으면 공멸

public class Enemy : MonoBehaviour
{
    
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;


    // 목표: 아래 방향으로 이동한다.
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }


    // 목표2: 다른 충돌체와 부딪혔으면 공멸
    //충돌 순간 실행
    private void OnCollisionEnter(Collision otherObject)
    {
        Destroy(otherObject.gameObject);
        

    }
    //충돌 중 실행
    private void OnCollisionStay(Collision collision)
    {
        
    }
    //충돌 종료시 실행
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
