using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void BackToMainMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame () {
        Debug.Log("Quit");
        Application.Quit();
    }
}
