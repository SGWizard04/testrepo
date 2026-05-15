using UnityEngine;

public class DestroyBelow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float destroyZ = -100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < destroyZ)
        { 
            Destroy(gameObject);
        }
        
    }
}
