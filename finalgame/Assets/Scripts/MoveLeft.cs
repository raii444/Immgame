using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private CarMovement carMovementScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        carMovementScript = GameObject.Find("Player").GetComponent<CarMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (carMovementScript != null && carMovementScript.rb.velocity.x > 0)
        {
            // Move to the left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else
        {
            // If the car is not moving to the right or script not found, destroy the GameObject
            Destroy(gameObject);
        }
    }
}
