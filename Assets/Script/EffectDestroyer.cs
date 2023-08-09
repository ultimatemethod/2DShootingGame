using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표: 이펙트의 파티클 효과 종료되면 자멸
//속성: 파티클시스템

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
            GameObject.Destroy(this.gameObject); // this유무
        }
    }
}
