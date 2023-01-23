using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMetalSpawner : MonoBehaviour
{
    public Collectable collectablePrefab;
    public List<Collectable> spawnedPrefabList = new List<Collectable>();
    public int maxSpawn = 10;
    public float spawnPeriod = 2f;
    private float nextSpawnTime = 0;
    void Update()
    {
        HandleNullElements();
        if (spawnedPrefabList.Count >= maxSpawn)
        {
            return;
        }

        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnPeriod;
            SpawnObject();
        }

    }

    private void SpawnObject()
    {     
            var collectable = Instantiate(collectablePrefab, transform);
            spawnedPrefabList.Add(collectable);
             
    }

    private void HandleNullElements()
    {
        for (int i = spawnedPrefabList.Count - 1; i >= 0; i--)
        {
            if (spawnedPrefabList[i] == null)
            {
                spawnedPrefabList.RemoveAt(i);
            }
        }

    }
}
