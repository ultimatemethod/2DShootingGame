using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float creatTime;
    float currentTime = 0;
    public GameObject bullet;

    // 랜덤한 시간의 최소 최대값
    public float minTime = 2;
    public float maxTime = 5;

    private void Start()
    {
        creatTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // 순서1. 현재 시간이 흐른다.        
        currentTime += Time.deltaTime;     

        // 순서2. 특정시간이 지나면
        if (currentTime > creatTime)
        {
            // 순서3. 총알을 Enemy위치에 생성
            GameObject enemyBullet = Instantiate(bullet);
            enemyBullet.transform.position = transform.position;

            // 순서4. 시간 초기화
            currentTime = 0;
        }
    }
}
