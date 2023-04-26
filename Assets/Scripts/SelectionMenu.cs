using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMenu : MonoBehaviour
{
    public GameObject[] players = new GameObject[6];
    public GameObject nextBttn;
    public GameObject backBttn;
    private int current = 0;

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

    private void changePlayer(int n) {
        players[current].SetActive(false);
        current += n;
        current = Mathf.Max(Mathf.Min(5, current),0);
        players[current].SetActive(true);
    }
}
