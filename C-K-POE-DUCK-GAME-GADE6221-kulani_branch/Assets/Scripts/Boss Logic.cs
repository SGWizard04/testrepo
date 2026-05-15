using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class BossLogic : MonoBehaviour
{
    public float timeElapsed;
    [Header("Settings")]
    
    public Transform playerTransform;
    public float followSpeed = 5f;
    public float xOffset = 0f;
    public float speed = 10f;
    public float moveDistance = 1f;
    [Header("Shooting")]
    public GameObject prefab;
    public GameObject boss;
    public GameObject projectilePrefab;
    public Transform shootPoint;
    private float nextFire;
    public float fireRate = 1f;
    public Vector3 shootDirection = Vector3.forward;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPrefab", 0f, fireRate);
        StartCoroutine(MoveEverySecond());
    }

    // Update is called once per frame
    void Update()
    {
       
        if (playerTransform != null)
        {
            FollowPlayer();
        }
        timer();
        shootHandling();
        

    }
   
    
    void FollowPlayer()
    {
        Vector3 targetPosition = new Vector3(playerTransform.position.x + xOffset, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
    
    void SpawnPrefab()
    {
        Vector3 spawnPos = boss.transform.position;
        Instantiate(prefab, spawnPos, Quaternion.identity);
       
    }
    IEnumerator MoveEverySecond()
    {
        while (true)
        {
            transform.position -= transform.forward * moveDistance;
            yield return new WaitForSeconds(speed);
        }
    }
    public void timer()
    {
        // Add the time passed since the last frame
        timeElapsed += Time.deltaTime;

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);

        if (timeElapsed > 15)
        {
            fireRate = 0.5f;
        }
        
    }
    public void shootHandling()
    {
        if (Time.time >= nextFire)
        {
            SpawnPrefab();
            nextFire = Time.time + fireRate;
        }
    }
   
}
