using System;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : Singleton<MonsterSpawner>
{
    public GameObject MonsterPrefab;
    public GameObject hpBar;
    public List<Dictionary<string, object>> monsterData;
    public List<RuntimeAnimatorController> animators;

    private int count = 0;

    void Start()
    {
        monsterData = CSVReader.Read("MonsterData");
        Spawn();
    }

    public void Spawn()
    {
        if (count== monsterData.Count)
        {
            count = 0;
        }
        GameObject monster = Instantiate(MonsterPrefab, gameObject.transform);
        Monster monsterScript = monster.GetComponent<Monster>();
        monsterScript.animator.runtimeAnimatorController = animators[count];
        string name = (string)monsterData[count]["Name"];
        string grade = (string)monsterData[count]["Grade"];
        float speed = Convert.ToSingle(monsterData[count]["Speed"]);
        Debug.Log(speed);
        int health = (int)monsterData[count]["Health"];
        monsterScript.data = new MonsterData(name,grade,speed,health);
        count++;
        hpBar.SetActive(true);
    }
}
