using UnityEngine;
using UnityEngine.UIElements;

public class cameraLogicDuck : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    public float smoothSpeed = 5f;

    private Vector3 Position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 target = player.position + offset;

        transform.position = player.position + offset;
        
    }
}
