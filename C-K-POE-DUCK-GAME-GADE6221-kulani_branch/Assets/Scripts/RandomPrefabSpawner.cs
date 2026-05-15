using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
using System;

public class RandomPrefabSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject[] prefabs;

    [Header("Prefab Settings")]

    public float spawnRate = 1f;

    public float spawnRange = 5f;

    public float moveDistance = 1f;

    public float moveSpeed = 0.5f;

    public static event Action OnPlayerDeath;



    void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, spawnRate);
        StartCoroutine(MoveEverySecond());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPrefab()
    {
        if (prefabs == null || prefabs.Length == 0)
        {
            Debug.LogError("No prefabs are currently assigned to this array");
            return;
        
        }
        int index = UnityEngine.Random.Range(0, prefabs.Length);

        float xPos = (spawnRange + UnityEngine.Random.Range(0f , 20f)) * (UnityEngine.Random.value > 0.5f ? -1 : 1); // Randomly choose left or right side

        Vector3 spawnPos = new Vector3
            (UnityEngine.Random.Range(-spawnRange, spawnRange), 
             10f, 500f);

        Instantiate(prefabs[index], spawnPos, Quaternion.identity);
    }
    IEnumerator MoveEverySecond()
    {
        while (true)
        {
            transform.position -= transform.forward * moveDistance;
            yield return new WaitForSeconds(moveSpeed);
        }
    }
}
