using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// ��ǥ: ����� �Է�(Space)�� �޾� �Ѿ��� ����� �ʹ�.
// ����1: �Է��� �ް� �ʹ�.
// ����2: �Ѿ��� ����� �ʹ�.

// ��ǥ2: �������� �Ծ��ٸ� ��ų ������ �ö󰣴�.
// �Ӽ�: ��ų���� 

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;
    public int skillLevel = 0;

    void Update()
    {
        // ����1: �Է��� �ް� �ʹ�.
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
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject BulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
            BulletGO.transform.position = gunPos.transform.position;
        }
        void ExecuteSkill1()
        {
            GameObject bulletGO = Instantiate(bullet);
            GameObject bulletGO1 = Instantiate(bullet);

            bulletGO.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO1.transform.position = gunPos.transform.position + new Vector3(0.2f, 0, 0);
        }
        // ������ �Ѿ��� �߻�
        // ���� Ʋ� 3�� ������
        void ExecuteSkill2()
        {
            // ����2: �Ѿ��� ����� �ʹ�.
            GameObject bulletGO = Instantiate(bullet);

            // ����3: �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� �����ְ� �ʹ�.
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

    //������ �Ա� ���⼭ ����
    //������ �ı� �� ����Ʈ

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item") // �÷��̾ �Դ´�
        {
            skillLevel++;
            Destroy(other.gameObject);

        }

    }
}
