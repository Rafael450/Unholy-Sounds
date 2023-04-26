using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class SelectionMenu : MonoBehaviour
{
    public GameObject[] players = new GameObject[6];
    public GameObject nextBttn;
    public GameObject backBttn;
    public Slider velBar;
    public Slider rangeBar;
    public Slider povBar;
    public Slider luckBar;
    public TMP_Text characterName;

    private int current = 0;

    void Start() {
        velBar.maxValue = 10;
        velBar.minValue = 4;

        rangeBar.maxValue = 30;
        rangeBar.minValue = 10;

        povBar.maxValue = 180;
        povBar.minValue = 0;

        luckBar.maxValue = 10;
        luckBar.minValue = 0;

        updateStats();

    }

    private void updateStats() {
        Debug.Log(players[current].GetComponent<Player>().characterName);
        velBar.value = players[current].GetComponent<Player>().moveSpeed;
        rangeBar.value = Flashlight.getOuterRadius(players[current].GetComponent<Player>().flashlightType);
        povBar.value = Flashlight.getOuterAngle(players[current].GetComponent<Player>().flashlightType);
        luckBar.value = players[current].GetComponent<Player>().luck;
        characterName.text = players[current].GetComponent<Player>().characterName;
        // if (current == 5) {
        //     povBar.gameObject.transform.Find("PovFillbar").Find("Fill").GetComponent<Image>().color = new Color(220/255f, 0/255f, 50/255f); 
        //     povBar.value = povBar.maxValue;
        // }
        // else {
        //     povBar.gameObject.transform.Find("PovFillbar").Find("Fill").GetComponent<Image>().color = new Color(54/255f, 219/255f, 9/255f); 
        //     povBar.value = Flashlight.getOuterAngle(players[current].GetComponent<Player>().flashlightType);
        // }

    }

    

    public void next() {
        if (current == 0)
            backBttn.SetActive(true);
        changePlayer(1);
        if (current == 5)
            nextBttn.SetActive(false);
    }

    public void back() {
        if (current == 5)
            nextBttn.SetActive(true);
        changePlayer(-1);
        if (current == 0)
            backBttn.SetActive(false);
    }

    public void startGame() {
        PlayerPrefs.SetInt("selectedCharacter", current);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void changePlayer(int n) {
        players[current].SetActive(false);
        current += n;
        current = Mathf.Max(Mathf.Min(5, current),0);
        players[current].SetActive(true);
        updateStats();
    }
}
