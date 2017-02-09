using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SpawnerPosition
{
    tLeftSpawn,
    tRightSpawn,
    bLeftSpawn,
    bRightSpawn
}

public class SpawnSystem : MonoBehaviour {
    public float spawnRate = 0.5f;
    private float spawnTime = 0.0f;
    private Vector2 position;
    private Vector2 velocity;
    private SpawnerPosition spawnPos;
    void Start()
    {
        position = transform.position;
        if (gameObject.name == "tLeftSpawn")
            spawnPos = SpawnerPosition.tLeftSpawn;
        else if (gameObject.name == "tRightSpawn")
            spawnPos = SpawnerPosition.tRightSpawn;
        else if (gameObject.name == "bLeftSpawn")
            spawnPos = SpawnerPosition.bLeftSpawn;
        else
            spawnPos = SpawnerPosition.bRightSpawn;
    }

    void Update()
    {
        float randomSpawn = Random.Range(0.0f, 1.0f);
        if (Time.time > spawnTime)
        {
            spawnTime = Time.time + spawnRate;
            if (randomSpawn > .45f)
            {
                _Spawn();
            }
        }
    }

    private void _Spawn()
    {
        GameObject obj = ObjectPoolSystem.current.GetPooledObject();
        if (obj == null) return;
        switch (spawnPos)
        {
            case SpawnerPosition.tLeftSpawn:
                obj.tag = "tLeftEnemy";
                break;
            case SpawnerPosition.tRightSpawn:
                obj.tag = "tRightEnemy";
                break;
            case SpawnerPosition.bLeftSpawn:
                obj.tag = "bLeftEnemy";
                break;
            case SpawnerPosition.bRightSpawn:
                obj.tag = "bRightEnemy";
                break;
        }
        obj.transform.position = position;
        obj.SetActive(true);
    }
}
