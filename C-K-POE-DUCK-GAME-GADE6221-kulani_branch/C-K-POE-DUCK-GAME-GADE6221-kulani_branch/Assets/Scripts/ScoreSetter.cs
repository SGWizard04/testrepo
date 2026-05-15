using UnityEngine;

public class ScoreSetter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision bubble_collision)
    {
        if (bubble_collision.gameObject.TryGetComponent<BubbleCollect>(out BubbleCollect player))
        {
            player.CollectBubbles(1);


            Destroy(gameObject);
        }
    }
}
