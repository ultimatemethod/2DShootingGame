using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// 목표: 사용자 입력(Space)를 받아 총알을 만들고 싶다.
// 순서1: 입력을 받고 싶다.
// 순서2: 총알을 만들고 싶다.

// 목표2: 아이템을 먹었다면 스킬 레벨이 올라간다.
// 속성: 스킬레벨 

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;
    public int skillLevel = 0;

    void Update()
    {
        // 순서1: 입력을 받고 싶다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExecuteSkill(skillLevel);
        }
    }

    private void ExecuteSkill(int _skillLevel)
    {
        switch (_skillLevel)
        {
            case 0:
                ExecuteSkill();
                break;
            case 1: 
                ExecuteSkill1(); 
                break;
            case 2: 
                ExecuteSkill2(); 
                break;
            case 3:
                ExecuteSkill3();
                break;
        }

        void ExecuteSkill()
        {
            // 순서2: 총알을 만들고 싶다.
            GameObject BulletGO = Instantiate(bullet);

            // 순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
            BulletGO.transform.position = gunPos.transform.position;
        }
        void ExecuteSkill1()
        {
            GameObject bulletGO = Instantiate(bullet);
            GameObject bulletGO1 = Instantiate(bullet);

            bulletGO.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO1.transform.position = gunPos.transform.position + new Vector3(0.2f, 0, 0);
        }
        // 세개의 총알이 발사
        // 각도 틀어서 3개 나간다
        void ExecuteSkill2()
        {
            // 순서2: 총알을 만들고 싶다.
            GameObject bulletGO = Instantiate(bullet);

            // 순서3: 총알의 위치를 플레이어의 위치로 정해주고 싶다.
            bulletGO.transform.position = gunPos.transform.position;

            GameObject bulletGO2 = Instantiate(bullet);
            GameObject bulletGO3 = Instantiate(bullet);

            bulletGO2.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
            bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;

            bulletGO3.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO3.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -30));
            bulletGO3.GetComponent<Bullet>().dir = bulletGO3.transform.up;
        }
        void ExecuteSkill3()
        {
            GameObject[] windmill = new GameObject[24];
            for (int i = 0; i < 24; i++)
            {
                windmill[i] = Instantiate(bullet);
                windmill[i].transform.position = gunPos.transform.position;
                windmill[i].transform.rotation = Quaternion.Euler(new Vector3(0, 0, 15 * i));
                windmill[i].GetComponent<Bullet>().dir = windmill[i].transform.up;
            }
        } 

    }

    //아이템 먹기 여기서 제어
    //아이템 파괴 및 이펙트

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item") // 플레이어만 먹는다
        {
            skillLevel++;
            Destroy(other.gameObject);

        }

    }
}
