using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ǥ: ����Ʈ�� ��ƼŬ ȿ�� ����Ǹ� �ڸ�
//�Ӽ�: ��ƼŬ�ý���

public class EffectDestroyer : MonoBehaviour
{
    ParticleSystem rootParticlesystem;

    // Start is called before the first frame update
    void Start()
    {
        rootParticlesystem = this.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!rootParticlesystem.IsAlive(true))
        {
            GameObject.Destroy(this.gameObject); // this����
        }
    }
}
