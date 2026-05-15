using TMPro;
using UnityEngine;

public class ShieldManager : MonoBehaviour
{
    public int shieldValue = 0;
    public TextMeshProUGUI shielded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
   
    public void CollectShield(int shield)
    {
        shieldValue += shield;
        UpdateUI();
    }
    public void ReduceShield(int amount)
    {
        shieldValue -= amount;
        if (shieldValue < 0)
        {
            shieldValue = 0;
        }
        UpdateUI();
    }
    void UpdateUI()
    {
        shielded.text = "Shield: " + shieldValue.ToString();
    }
    private void OnCollisionEnter(Collision LilyPad)
    {
        if (LilyPad.gameObject.CompareTag("Shield"))
        {
           
            Destroy(LilyPad.gameObject);

            if(shielded != null)
            {
                shieldValue += 1;
               shielded.text = "Shield: " + shieldValue.ToString();
            }
        }
    }
}
