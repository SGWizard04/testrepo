using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnStartClick()
    {
        SceneManager.LoadScene("gameScene"); // once the start button is clicked, the game will load the scene named "gameScene"
    }

    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in the editor
#endif
        Application.Quit(); // Quit the application when the exit button is clicked
    }

    public void OnInstructionsClick()
    {
        SceneManager.LoadScene("InstructionsScene"); // Load the instructions scene when the instructions button is clicked
    }
}