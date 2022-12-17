
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // The speed at which the car should move
    public float speed = 10f;

    public float sidewaysForce = 500f;

    // The maximum tilt angle of the car when turning
    public float maxTiltAngle = 20f;

    // The amount of tilt applied to the car when turning
    private float tiltAmount;

    // The car's rigidbody component
    private Rigidbody rb;

    void Start()
    {
        // Get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        // Get the vertical input from the player
        float verticalInput = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1f;
        }

        // Calculate the force to apply to the car based on the input and speed
        Vector3 force = transform.forward * speed * verticalInput;

        // Apply the force to the car's rigidbody
        rb.AddForce(force);
    
    
        if ( Input.GetKey("d") )
        {
            rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(- sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
