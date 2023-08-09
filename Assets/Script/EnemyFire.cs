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
        // ����1. ���� �ð��� �帥��.        
        currentTime += Time.deltaTime;     

        // ����2. Ư���ð��� ������
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
