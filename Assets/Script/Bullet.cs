using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 목표: 내가(총알) 위로 날아간다.
// 방향과 속도가 필요하다.


public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;


    // 목표: 내가(총알) 위로 날아간다.
    void Update()
    {
        
        transform.position += dir * speed * Time.deltaTime;
        

    }

    
}
