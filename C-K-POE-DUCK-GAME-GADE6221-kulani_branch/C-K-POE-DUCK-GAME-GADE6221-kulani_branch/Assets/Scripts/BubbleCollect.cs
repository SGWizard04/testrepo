using TMPro;
using UnityEngine;

public class BubbleCollect : MonoBehaviour
{
    public int scoreValue = 0; // The score value of this bubble
    public TextMeshProUGUI bubbleScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
   
    public void CollectBubbles(int score)
    {
        scoreValue += score;
        UpdateUI();
    }
    void UpdateUI()
    {
        bubbleScore.text = "score: " + scoreValue.ToString();
    }
}
