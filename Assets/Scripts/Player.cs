using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    // [SerializeField] private string characterName;
    // [SerializeField] private float moveSpeed;

    public string characterName;
    public float moveSpeed;
    public FlashlightType flashlightType;
    public int luck = 5;
    public bool active = true;
    public Flashlight flashlight;
    public CollectibleItem collect;
    private UnityEngine.Rendering.Universal.Light2D light2d;
    private Movimento movement;
    public GameObject letterE;
    private int velvaCounter = 0;


    public float timer = 0;
    private EnergyDrinkType currentPowerUp;
    public bool isPowerUpActive = false;

    private float pickupTimer = 0;


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
        light2d.pointLightOuterAngle = Flashlight.getOuterAngle(flashlightType);
        light2d.pointLightOuterRadius = Flashlight.getOuterRadius(flashlightType);
    
        letterE = GameObject.FindGameObjectWithTag("LetterE");
        letterE.SetActive(false);
    }

    void Update() {
        if (pickupTimer > 0)
            pickupTimer -= Time.deltaTime;
        if (timer <= 0 && isPowerUpActive == false) return;
        if (timer <= 0 && isPowerUpActive) {
            movement.speed -= EnergyDrink.getSpeedBoost(currentPowerUp);
            isPowerUpActive = false;
            return;
        }
        timer -= Time.deltaTime;
    }

    void powerUp(GameObject gameObject) {
        if (isPowerUpActive) {
            movement.speed -= EnergyDrink.getSpeedBoost(currentPowerUp);
            isPowerUpActive = false;
        }
        currentPowerUp = gameObject.GetComponent<EnergyDrink>().itemType;
        timer = EnergyDrink.getDuration(currentPowerUp);
        movement.speed += EnergyDrink.getSpeedBoost(currentPowerUp);
        isPowerUpActive = true;

    }

    void newVelva() {
        velvaCounter += 1;
        if (velvaCounter == 5) 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    void newFlashlight(GameObject gameObject) {
        flashlightType = gameObject.GetComponent<Flashlight>().flashlightType;
        light2d.pointLightOuterAngle = Flashlight.getOuterAngle(flashlightType);
        light2d.pointLightOuterRadius = Flashlight.getOuterRadius(flashlightType);
    }

    void Pickup(Collider2D other)
    {
        // Delete the item from the scene
        switch (other.gameObject.tag)
        {
            case "Energy":
                // Do something if the object's tag is "Energy"
                powerUp(other.gameObject);

                break;
            case "Velva":
                // Do something if the object's tag is "Velva"
                newVelva();
                break;
            case "Flashlight":
                // Do something if the object's tag is "Flashlight"
                newFlashlight(other.gameObject);
                break;
            default:
                break;
        }

        Destroy(other.gameObject);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        letterE.SetActive(true);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        letterE.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKey(KeyCode.E))
        {
            if (pickupTimer <= 0) {
                pickupTimer = 0.5f;
                Pickup(other);
            }
        }
    }
}
