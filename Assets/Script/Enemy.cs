using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ��ǥ: �Ʒ� �������� �̵�
// ��ǥ2: �ٸ� ��ü�� �浹�� ����

// ��ǥ3: ���۽� 50% Ȯ���� �÷��̾ ���󰣴�.

// ��ǥ4: 10% Ȯ���� �÷��̾ ���󰣴�.
// ���� ����

// ��ǥ5: �÷��̾ ���� ���� ���.
// �ʿ�Ӽ�: �Ѿ�, Ư���ð�

// ��ǥ6: �浹�� ���� ȿ�� ����
// �ʿ�Ӽ�: ����ȿ�� ���ӿ�����Ʈ

// ��ǥ7: �浹�� hp ����
// getComponent

public class Enemy : MonoBehaviour
{

    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    // �ʿ�Ӽ�: �÷��̾��� ����
    Vector3 playerDir;

    // �ʿ�Ӽ�: ����ȿ�� ���ӿ�����Ʈ
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

    // ��ǥ: �Ʒ� �������� �̵�
    void Update()
    {
        // ��ǥ4 : 10������ Ȯ���� �÷��̾ ���󰣴�.
        // ���� ����

        transform.position += dir * speed * Time.deltaTime;
    }

    // ��ǥ2: �ٸ� �浹ü�� �ε������� ����
    // �浹 ���� ����
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

            // ��ǥ6: �浹�� ���� ȿ��
            GameObject explosionGO = Instantiate(explosionEff);
            explosionGO.transform.position = gameObject.transform.position;                                   
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
