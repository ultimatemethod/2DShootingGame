using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����(�Ѿ�) ���� ���ư���.
// ����� �ӵ��� �ʿ��ϴ�.


public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;


    // ��ǥ: ����(�Ѿ�) ���� ���ư���.
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
