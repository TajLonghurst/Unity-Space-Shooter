using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanwer : MonoBehaviour
{

    float spawnDistance = 20f;

public GameObject enemyPrefab;
    public float EnemySpawnRate = 5;
    float NextEnemy = 1;
    // Update is called once per frame
    void Update()
    {
        NextEnemy -= Time.deltaTime;

        if (NextEnemy <= 0)
        {
            NextEnemy = EnemySpawnRate;
            EnemySpawnRate *= 0.9f;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * spawnDistance;
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
