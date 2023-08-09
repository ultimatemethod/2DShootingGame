using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//목표: 스킬아이템을 특정시가 마다 만든다.
//필요속성: 스킬아이템, 특정시간, 현재시간
//단계1. 시간이 흐른다.
//단계2. 현재 시간이 특정시간을 넘으면
//단계3. 스킬아이템 생성


public class SkillManager : MonoBehaviour
{
    public GameObject skillItem;
    public float creatTime;
    float currentTime;

    public float minCreatTime = 3;
    public float maxCreatTime = 10;

    private void Start()
    {
        creatTime = UnityEngine.Random.Range(minCreatTime, maxCreatTime);

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > creatTime)
        {
            GameObject skillItemGO = Instantiate(skillItem);
            skillItemGO.transform.position = transform.position;
            currentTime = 0;

            //단계5. 시간을 다시 설정
            creatTime = UnityEngine.Random.Range(minCreatTime, maxCreatTime);
        }


    }
}
