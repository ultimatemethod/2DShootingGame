using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 목표: 아래 방향으로 이동
// 목표2: 다른 물체와 충돌시 공멸

// 목표3: 시작시 50% 확률로 플레이어를 따라간다.

// 목표4: 10% 확률로 플레이어를 따라간다.
// 구현 생략

// 목표5: 플레이어를 향해 총을 쏜다.
// 필요속성: 총알, 특정시간

// 목표6: 충돌시 폭발 효과 생성
// 필요속성: 폭발효과 게임오브젝트

// 목표7: 충돌시 hp 감소
// getComponent

public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    // 필요속성: 플레이어의 방향
    Vector3 playerDir;

    // 필요속성: 폭발효과 게임오브젝트
    public GameObject explosionEff;

    private void Start()
    {
        // 50%
        randValue = Random.Range(0, 10); // 0~9
        player = GameObject.Find("Player");
        if (randValue < 5)
        {
            if (player != null)
            {
                dir = (player.transform.position - gameObject.transform.position).normalized;
            }                           
        }
    }

    // 목표: 아래 방향으로 이동
    void Update()
    {
        // 목표4 : 10프로의 확률로 플레이어를 따라간다.
        // 구현 생략

        transform.position += dir * speed * Time.deltaTime;
    }

    // 목표2: 다른 충돌체와 부딪혔으면 공멸
    // 충돌 순간 실행
    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerMove>().hp--;

            if (player.GetComponent<PlayerMove>().hp < 0)
            {
                Destroy(otherObject.gameObject);
            }

            Destroy(gameObject);

            // 목표6: 충돌시 폭발 효과
            GameObject explosionGO = Instantiate(explosionEff);
            explosionGO.transform.position = gameObject.transform.position;                                   
        }
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
