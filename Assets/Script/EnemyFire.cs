using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{  
    public GameObject bullet;
    public GameObject gunPos;
    float currentTime;
    public float creatTime = 1;
    GameObject player;
    Vector3 playerDir;


    private void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // 순서1. 현재 시간이 흐른다.        
        currentTime += Time.deltaTime;     

        // 순서2. 특정시간이 지나면
        if (currentTime > creatTime)
        {
            GameObject bulletGO = Instantiate(bullet);
            //bulletGO.tag = "EnemyBullet";

            bulletGO.transform.position = gunPos.transform.position;

            playerDir = (player.transform.position - gameObject.transform.position).normalized;
            bulletGO.GetComponent<E_Bullet>().dir = playerDir;
            Debug.Log(creatTime);

            currentTime = 0;
        }
    }
}
