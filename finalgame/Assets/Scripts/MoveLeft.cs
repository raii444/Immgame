using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private float resetPosition = -30; // Adjust this value based on your background size

    // Update is called once per frame
    void Update()
    {
        // Move to the left continuously
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        // Check if the background has reached the reset position
        if (transform.position.x <= resetPosition)
        {
            // Reposition the background to the right of the other one
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        // Find all objects with the same name as this one
        GameObject[] backgrounds = GameObject.FindGameObjectsWithTag("Background");

        // Find the rightmost background
        float rightmostX = float.MinValue;
        foreach (GameObject background in backgrounds)
        {
            float x = background.transform.position.x;
            if (x > rightmostX)
            {
                rightmostX = x;
            }
        }

        // Set this background's position to the right of the rightmost background
        transform.position = new Vector3(rightmostX + resetPosition, transform.position.y, transform.position.z);
    }
}
