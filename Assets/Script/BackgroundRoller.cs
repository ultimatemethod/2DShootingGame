using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: Background�� Material�� offset�� Y�� �����ӵ��� ��ȭ��Ű�� �ʹ�.
// �Ӽ�: ����ð�, �ӵ�, Material

public class BackgroundRoller : MonoBehaviour
{
    // �Ӽ�
    float currentTime;
    public float speed = 1;
    public Material material;

    // Update is called once per frame
    void Update()
    {
        currentTime += speed * Time.deltaTime;
        material.mainTextureOffset = Vector3.up * currentTime;

    }
}
