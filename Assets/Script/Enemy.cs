using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ��ǥ: �Ʒ� �������� �̵��Ѵ�.
// ��ǥ2: �ٸ� �浹ü�� �ε������� ����

// ��ǥ3: ���۽� 50%�� Ȯ���� �÷��̾ ���󰣴�.
// �ʿ�Ӽ�: 50%�� Ȯ��

// ��ǥ4: 10%Ȯ���� �÷��̾ ���󰣴�.
// �ʿ�Ӽ�: �÷��̾��� ����

// ��ǥ5: ���� �÷��̾ ���� ���� ���.
// �ʿ�Ӽ�: �Ѿ�, 30%, Ư���ð�

public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    // �ʿ�Ӽ�: �÷��̾��� ����
    Vector3 playerDir;

    // �ʿ�Ӽ�: �Ѿ�, 30%, Ư���ð�
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

    // ��ǥ: �Ʒ� �������� �̵��Ѵ�.
    void Update()
    {
        
        //if (randValue < 3)
        //{
        //    playerDir = (player.transform.position - gameObject.transform.position).normalized;
        //    dir = playerDir;
        //}
        transform.position += dir * speed * Time.deltaTime;

        // ��ǥ5
        //if (randValue < 3)
        //{
        //    GameObject bulletGO = Instantiate(bullet);
        //    bulletGO.transform.position = gameObject.transform.position;


        //}

        
    }


    // ��ǥ2: �ٸ� �浹ü�� �ε������� ����
    //�浹 ���� ����
    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            Destroy(otherObject.gameObject);
            Destroy(gameObject);
        }        
    }
    //�浹 �� ����
    private void OnCollisionStay(Collision collision)
    {

    }
    //�浹 ����� ����
    private void OnCollisionExit(Collision collision)
    {

    }
}
