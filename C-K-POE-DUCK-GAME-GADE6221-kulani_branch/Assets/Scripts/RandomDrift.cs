using UnityEngine;

public class RandomDrift : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float driftForce = 2f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 randomForce = new Vector3(
            Random.Range(-driftForce, driftForce),
            0,
            Random.Range(-driftForce, driftForce));

        rb.AddForce(randomForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
