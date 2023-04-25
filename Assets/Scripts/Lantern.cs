using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{    
    void Update()
    {
        Cursor.visible = false;
        // Get the position of the mouse pointer in screen coordinates
        Vector3 mousePos = Input.mousePosition;

        // Calculate the direction from the light position to the mouse position
        Vector3 direction = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;
        // direction.z = 0; // Set the Z component to zero to keep the rotation in 2D

        // Rotate the light to face the mouse direction
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.forward);
    }
}
