using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����(�Ѿ�) ���� ���ư���.
// ����� �ӵ��� �ʿ��ϴ�.


public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;
    public GameObject bulletExplosion;

    // ��ǥ: ����(�Ѿ�) ���� ���ư���.
    void Update()
    {
        
        transform.position += dir * speed * Time.deltaTime;      
    }

    private void OnCollisionEnter(Collision otherObject)
    {

        Destroy(otherObject.gameObject);
        Destroy(gameObject);

        GameObject bulletExplosionGO = Instantiate(bulletExplosion);
        bulletExplosionGO.transform.position = transform.position;

    }


}
