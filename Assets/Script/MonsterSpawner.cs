using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject MonsterPrefab;

    public event Action OnSpawn;
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

        monsterScript.data = new MonsterData((string)monsterData[count]["Name"], (string)monsterData[count]["Grade"], (float)monsterData[count]["Speed"], (int)monsterData[count]["Health"]);
        count++;
    }
}
