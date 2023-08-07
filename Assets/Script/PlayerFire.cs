using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 목표: 사용자 입력(Space)를 받아 총알을 만들고 싶다.
// 순서1: 입력을 받고 싶다.
// 순서2: 총알을 만들고 싶다.

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        // 순서1: 입력을 받고 싶다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 순서2: 총알을 만들고 싶다.
            GameObject BulletGO = Instantiate(bullet);

            // 순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
            BulletGO.transform.position = transform.position; // 그냥 써주면 스크립트의 position

        }
    }
}
