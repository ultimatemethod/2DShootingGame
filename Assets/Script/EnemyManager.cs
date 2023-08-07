using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ���� �����Ѵ�.
// �ʿ� �Ӽ�:  Ư�� �ð�, ���� �ð�, �� GameOject
// ����1: Ư�� �ð��� �帥��.
// ����2: ���� �ð��� Ư���ð��� �Ǹ�
// ����3: ���� �����ؼ� EnemyManager��ġ�� �����Ѵ�.
// ����4: �ð��� �ʱ�ȭ ���ش�.

// �߰�. Ư���ð��� ������ �ð����� �����Ѵ�.
public class EnemyManager : MonoBehaviour
{
    // �ʿ� �Ӽ�:  Ư�� �ð�, ���� �ð�, �� GameOject
    // Ư���ð�
    public float creatTime;  
    
    // ����ð�
    float currentTime = 0;

    // �� ���ӿ�����Ʈ 
    public GameObject enemy;

    // ������ �ð��� �ּ� �ִ밪
    public float minTime = 3;
    public float maxTime = 5;

    private void Start()
    {
        creatTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ����1. ���� �ð��� �帥��.
        // currentTime = currentTime + Time.deltaTime;
        currentTime += Time.deltaTime;
        print("CurrentTime: " + currentTime);

        // ����2. Ư���ð��� ������
        if(currentTime > creatTime)
        {
            // ����3. ���� EnemyManager��ġ�� ����
            GameObject enemyG0 = Instantiate(enemy);
            enemyG0.transform.position = transform.position;

            // ����4. �ð� �ʱ�ȭ
            currentTime = 0;
        }
    }
}
