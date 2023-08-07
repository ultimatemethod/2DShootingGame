using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Bullet : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir = Vector3.down;


    // ��ǥ: ����(�Ѿ�) ���� ���ư���.
    void Update()
    {

        transform.position += dir * speed * Time.deltaTime;

    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            Destroy(otherObject.gameObject);
            Destroy(gameObject);
        }
    }
}
