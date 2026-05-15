using UnityEngine;

public class ShieldCollect : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision LilyPad)
    {
        if (LilyPad.gameObject.TryGetComponent<ShieldManager>(out ShieldManager player))
        {
            player.CollectShield(1);

            Destroy(gameObject);
        }
    }
}
