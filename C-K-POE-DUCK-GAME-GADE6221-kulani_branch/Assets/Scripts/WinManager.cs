using UnityEngine;
using System.Collections;
public class WinManager : MonoBehaviour
{
    private bool hasWon = false; // Flag to track if the player has won
    [Header("Win Manager Settings")]
    public float moveDistance = 1f;
    public float moveSpeed = 1f;
   
    public GameObject WinBanenr; // Reference to the win banner GameObject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    private void OnEnable()
    {
        StartCoroutine(MoveEverySecond());
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
