using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��ǥ: ��ų�������� �Ʒ��� �̵��Ѵ�. 


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

        //��ǥ3. ���߽� ���� ����Ʈ�� ����
        //����1. ���� �Ŵ��� �ҷ��´�.
        GameObject soundManager = GameObject.Find("SoundManager");

        AudioSource audioSource = soundManager.GetComponent<SoundManager>().effAudioSource;
        //����2. ���� �Ŵ������� ����� �ҽ��� ����� Ŭ���� �������ش�.
        audioSource.clip = soundManager.GetComponent<SoundManager>().itemAudioClips[0];

        //����3. ���� �Ŵ����� ����� �ҽ��� �����Ų��.
        audioSource.Play();

    }
}
