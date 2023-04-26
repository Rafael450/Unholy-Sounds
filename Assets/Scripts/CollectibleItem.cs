using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public GameObject letterE;
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
            Pickup(other);
        }
    }

    void Pickup(Collider2D other)
    {
        // Delete the item from the scene
        switch (other.gameObject.tag)
        {
            case "Energy":
                // Do something if the object's tag is "Energy"
                break;
            case "Velva":
                // Do something if the object's tag is "Velva"
                break;
            case "Flashlight":
                // Do something if the object's tag is "Flashlight"
                break;
            default:
                break;
        }

        Destroy(other.gameObject);
    }
}