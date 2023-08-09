using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Bullet : MonoBehaviour
{
    public float speed = 3.0f;
    public Vector3 dir = Vector3.down;
    public GameObject bulletExplosion;

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
