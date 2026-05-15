using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Floating : MonoBehaviour
{
    [Header("Settings")]
    public float amplitude = 0.5f; // How high the object floats
    public float frequency = 1f; // How fast the object floats
    private Rigidbody rb; 
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float Y_pos = startPos.y + Mathf.Sin(frequency * amplitude);
        rb.MovePosition(new Vector3(startPos.x, Y_pos, startPos.z));
    }
}
