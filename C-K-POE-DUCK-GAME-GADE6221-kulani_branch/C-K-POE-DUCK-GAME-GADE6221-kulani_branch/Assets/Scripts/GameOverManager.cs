using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void OnRestartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameScene"); // this will allow the player to restart the game on the level they just completed 
    }

    public void OnMainMenuClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu"); // this will take the player bac to the main menu where they can start a new game or exit the game
    }
}