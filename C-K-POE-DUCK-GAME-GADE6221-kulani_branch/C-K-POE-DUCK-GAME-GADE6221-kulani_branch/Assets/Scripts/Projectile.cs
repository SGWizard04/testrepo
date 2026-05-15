using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    [Header("Projectile Settings")]
    public GameObject projectilePrefab;
    public float speed = 10f;
    public float moveDistance = 1f;
    public float spawnRate = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    IEnumerator MoveEverySecond()
    {
        while (true)
        {
            transform.position -= transform.forward * moveDistance;
            yield return new WaitForSeconds(speed);
        }
    }
}
