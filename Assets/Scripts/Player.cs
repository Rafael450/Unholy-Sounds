using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class Player : MonoBehaviour
{
    // [SerializeField] private string characterName;
    // [SerializeField] private float moveSpeed;

    public string characterName;
    public float moveSpeed;
    public FlashlightType flashlightType;
    public bool active = true;
    private Flashlight flashlight;
    private UnityEngine.Rendering.Universal.Light2D light2d;
    private Movimento movement;


    // ideias: escudo, boostSpeed, lucky

    void Start()
    {
        movement = gameObject.AddComponent<Movimento>();
        if (active == false) {
            movement.speed = 0;
            return;
        }
        movement.speed = moveSpeed;

        flashlight = gameObject.AddComponent<Flashlight>();
        flashlight.flashlightType = flashlightType;

        light2d = GameObject.FindGameObjectWithTag("PlayerLight").GetComponent<Light2D>();;
        light2d.pointLightInnerAngle = 37;
        light2d.pointLightOuterAngle = flashlight.getOuterAngle();
        light2d.pointLightOuterRadius = flashlight.getOuterRadius();
    }

}
