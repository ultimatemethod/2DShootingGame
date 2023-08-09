using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//목표: 스킬아이템이 아래로 이동한다. 


public class SkillItemMove : MonoBehaviour
{
    public float speed = 0.5f;
    public Vector3 dir = Vector3.down;

    public GameObject itemEffect;

    public AudioSource soundEffect;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * dir * Time.deltaTime;
    }

    private void OnDestroy()
    {
        GameObject ItemEffGO = Instantiate(itemEffect);
        ItemEffGO.transform.position = transform.position;

        //목표3. 폭발시 사운드 이펙트를 생성
        //순서1. 사운드 매니저 불러온다.
        GameObject soundManager = GameObject.Find("SoundManager");

        AudioSource audioSource = soundManager.GetComponent<SoundManager>().effAudioSource;
        //순서2. 사운드 매니저에서 오디오 소스의 오디오 클립을 변경해준다.
        audioSource.clip = soundManager.GetComponent<SoundManager>().itemAudioClips[0];

        //순서3. 사운드 매니저의 오디오 소스를 재생시킨다.
        audioSource.Play();

    }
}
