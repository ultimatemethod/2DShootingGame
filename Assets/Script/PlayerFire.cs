using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: ����� �Է�(Space)�� �޾� �Ѿ��� ����� �ʹ�.
// ����1: �Է��� �ް� �ʹ�.
// ����2: �Ѿ��� ����� �ʹ�.

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        // ����1: �Է��� �ް� �ʹ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject BulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            BulletGO.transform.position = transform.position; // �׳� ���ָ� ��ũ��Ʈ�� position

        }
    }
}
