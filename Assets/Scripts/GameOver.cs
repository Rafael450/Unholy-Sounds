using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start() {
        Cursor.visible = true;
    }
    public void BackToMainMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame () {
        Debug.Log("Quit");
        Application.Quit();
    }
}
