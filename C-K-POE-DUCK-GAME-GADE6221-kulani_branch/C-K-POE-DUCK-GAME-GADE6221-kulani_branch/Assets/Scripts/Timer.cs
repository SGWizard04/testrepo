using UnityEngine;
using TMPro; // Required for TextMesh Pro

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; //timer object
    
    private float timeElapsed;
    
    void Start()
    {
        timeElapsed = 0f; // Initialize the timer

    }
    void Update()
    {
        timer();
    }
    public void timer()
    {
        // Add the time passed since the last frame
        timeElapsed += Time.deltaTime;

        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);

        // Update the text in 00:00 format
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}