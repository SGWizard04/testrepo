using JetBrains.Annotations;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject container;

    private bool isPaused = false;

    private void Start()
    {
        container.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }
    void PauseGame()
    {
        container.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame()
    {
        container.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void ResumeButton()
    {
        ResumeGame();
    }

    public void MainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
    }

}
