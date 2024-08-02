using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This method is called when the player presses a button to load a specific scene
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // This method is called when the player presses the Quit button
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
