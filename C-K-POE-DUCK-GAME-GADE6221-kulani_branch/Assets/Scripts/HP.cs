using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HP : MonoBehaviour
{
    public int health = 10;
    public TextMeshProUGUI hpDisplay;

    public GameManagerScript gameManager;
   public ShieldManager shieldManager;
    private bool isDead;

    void Start()
    {
        shieldManager = GetComponent<ShieldManager>();
        UpdateUI();
    }

    // This function can be called by other scripts
    public void TakeDamage(int amount)
    {

        if (shieldManager != null && shieldManager.shieldValue > 0)
        {
            if (amount <= shieldManager.shieldValue)
            {
                // Shield absorbs all damage
                shieldManager.ReduceShield(amount);
                return; // Stop here, no damage to HP
            }
            else
            {
                // Shield breaks! Calculate remaining damage
                int remainingDamage = amount - shieldManager.shieldValue;
                shieldManager.ReduceShield(shieldManager.shieldValue); // Set shield to 0
                health -= remainingDamage;
            }
        }
        else
        {
            // 2. No shield at all, take direct health damage
            health -= amount;
        }

        UpdateUI();


    }
    private void Update()
    {
        if (health <= 0)
        {
            Dead();
        }
    }
    void Dead()
    {
           SceneManager.LoadScene("DeathScene"); 

    }
    void UpdateUI()
    {
        hpDisplay.text = "HP: " + health.ToString();
    }
}