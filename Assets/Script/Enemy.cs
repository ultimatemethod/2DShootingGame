using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 목표: 아래 방향으로 이동한다.
// 목표2: 다른 충돌체와 부딪혔으면 공멸

// 목표3: 시작시 50%의 확률로 플레이어를 따라간다.
// 필요속성: 50%의 확률

// 목표4: 10%확률로 플레이어를 따라간다.
// 필요속성: 플레이어의 방향

// 목표5: 적도 플레이어를 향해 총을 쏜다.
// 필요속성: 총알, 30%, 특정시간

public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    // 필요속성: 플레이어의 방향
    Vector3 playerDir;

    // 필요속성: 총알, 30%, 특정시간
    // public GameObject bullet;
    public float fireTime = 1;
    int percentage = 3;


    private void Start()
    {
        randValue = Random.Range(0, 10); // 0~9
        player = GameObject.Find("Player");
        if (randValue < 5)
        {
            player = GameObject.Find("Player");
            dir = (player.transform.position - gameObject.transform.position).normalized;
        }        
    }

    // 목표: 아래 방향으로 이동한다.
    void Update()
    {
        
        //if (randValue < 3)
        //{
        //    playerDir = (player.transform.position - gameObject.transform.position).normalized;
        //    dir = playerDir;
        //}
        transform.position += dir * speed * Time.deltaTime;

        // 목표5
        //if (randValue < 3)
        //{
        //    GameObject bulletGO = Instantiate(bullet);
        //    bulletGO.transform.position = gameObject.transform.position;


        //}

        
    }


    // 목표2: 다른 충돌체와 부딪혔으면 공멸
    //충돌 순간 실행
    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            Destroy(otherObject.gameObject);
            Destroy(gameObject);
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
