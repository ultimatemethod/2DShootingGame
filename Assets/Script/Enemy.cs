using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ��ǥ: �Ʒ� �������� �̵��Ѵ�.
// ��ǥ2: �ٸ� �浹ü�� �ε������� ����

public class Enemy : MonoBehaviour
{
    
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;


    // ��ǥ: �Ʒ� �������� �̵��Ѵ�.
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }


    // ��ǥ2: �ٸ� �浹ü�� �ε������� ����
    //�浹 ���� ����
    private void OnCollisionEnter(Collision otherObject)
    {
        Destroy(otherObject.gameObject);
        

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
