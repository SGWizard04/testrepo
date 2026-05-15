using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the thing we hit has the PlayerHealth script
        if (collision.gameObject.TryGetComponent<HP>(out HP player))
        {
            player.TakeDamage(1);

            
            Destroy(gameObject);
        }
    }
}
