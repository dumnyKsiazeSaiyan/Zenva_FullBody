using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Loops : MonoBehaviour
{
    public GameObject spawnPrefab;

    public int spawnCount = 5;
    public float spawnOffset = 1.5f;

    private void Start()
    {
        
        if(spawnPrefab != null)
        {
            SpawnEnemies();
        }
        else
        {
            Debug.LogError("Cannot spawn enemies! Prefab is missing.");
            Debug.LogWarning("Cannot spawn enemies! Prefab is missing.");
            Debug.Log("Cannot spawn enemies! Prefab is missing.");
        }
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            float xPos = i * spawnOffset;
            Vector3 spawnPos = new(xPos, 0, 0);

            Instantiate(spawnPrefab, spawnPos, Quaternion.identity);
        }
    }
}
