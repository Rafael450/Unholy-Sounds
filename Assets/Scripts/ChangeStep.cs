using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChangeStep : MonoBehaviour
{
    private int currentStep = 0;
    private GameObject[] steps = new GameObject[4];
    private GameObject[] arrows = new GameObject[2];

    void Start() {
        steps[0] = GameObject.Find("Canvas/TutorialMenu/Moving");
        steps[1] = GameObject.Find("Canvas/TutorialMenu/Picking");
        steps[2] = GameObject.Find("Canvas/TutorialMenu/Run");
        steps[3] = GameObject.Find("Canvas/TutorialMenu/Collect");

        arrows[0] = GameObject.Find("Canvas/TutorialMenu/AdvanceBttn");
        arrows[1] = GameObject.Find("Canvas/TutorialMenu/ReturnBttn");
    }

    private void changeStep(int n) {
        currentStep += n;
        currentStep = Math.Max(0, Math.Min(3, currentStep));

        for (int i=0; i < 4; i++) {
            if (i != currentStep)
                steps[i].SetActive(false);
            else
                steps[i].SetActive(true);
        }

        if (currentStep == 0)
            arrows[1].SetActive(false);
        else if (currentStep == 1) 
            arrows[1].SetActive(true);
        else if (currentStep == 2) 
            arrows[0].SetActive(true);
        else
            arrows[0].SetActive(false); 
    }

    public void advanceStep() {
        changeStep(1);
    }
    public void returnStep() {
        changeStep(-1);
    }
}
