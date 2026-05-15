using UnityEngine;
using UnityEngine.SceneManagement;


public class InstructionsMenuController : MonoBehaviour
{
    public void OnBackClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
    }
}

