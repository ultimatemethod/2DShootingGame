using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ǥ: ��ų�������� Ư���ð� ���� �����.
//�ʿ�Ӽ�: ��ų������, Ư���ð�, ����ð�
//�ܰ�1. �ð��� �帥��.
//�ܰ�2. ���� �ð��� Ư���ð��� ������
//�ܰ�3. ��ų������ ����


public class SkillManager : MonoBehaviour
{
    public GameObject skillItem;
    public float creatTime;
    float currentTime;

    public float minCreatTime = 3;
    public float maxCreatTime = 10;

    private void Start()
    {
        creatTime = UnityEngine.Random.Range(minCreatTime, maxCreatTime);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > creatTime)
        {
            GameObject skillItemGO = Instantiate(skillItem);
            skillItemGO.transform.position = transform.position;
            currentTime = 0;

            //�ܰ�5. �ð��� �ٽ� ����
            creatTime = UnityEngine.Random.Range(minCreatTime, maxCreatTime);
        }


    }
}
