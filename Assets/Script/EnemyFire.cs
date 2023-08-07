using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public float creatTime;
    float currentTime = 0;
    public GameObject bullet;

    // ������ �ð��� �ּ� �ִ밪
    public float minTime = 2;
    public float maxTime = 5;

    private void Start()
    {
        creatTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ����1. ���� �ð��� �帥��.        
        currentTime += Time.deltaTime;     

        // ����2. Ư���ð��� ������
        if (currentTime > creatTime)
        {
            // ����3. �Ѿ��� Enemy��ġ�� ����
            GameObject enemyBullet = Instantiate(bullet);
            enemyBullet.transform.position = transform.position;

            // ����4. �ð� �ʱ�ȭ
            currentTime = 0;
        }
    }
}
