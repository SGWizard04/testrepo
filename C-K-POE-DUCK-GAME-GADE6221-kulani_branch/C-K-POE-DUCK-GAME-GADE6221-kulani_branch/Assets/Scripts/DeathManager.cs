using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public GameObject deathScreen; // Reference to the death screen UI
    public TextMeshProUGUI scoreText; // Reference to the score text UI

    private bool isDead = false;
    private HP playerHealth;
    private BubbleCollect bubbleScore; // Reference to the player's bubble score

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HP>();

        // Cache the ScoreManager (assuming it's on a "GameManager" object or the Player)
        bubbleScore = FindFirstObjectByType<BubbleCollect>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerHealth != null && playerHealth.health <= 0 && !isDead)
        {
            
            ShowDeathScreen();
        }
    }
    void ShowDeathScreen()
    {
        isDead = true;

        // Update the text with the current score before showing the screen
        if (bubbleScore != null && scoreText != null)
        {
            // Fix: use the numeric score field instead of the method
            scoreText.text = "Final Score: " + bubbleScore.scoreValue.ToString();
        }

        deathScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
