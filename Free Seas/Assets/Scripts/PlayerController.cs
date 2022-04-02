using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// gameobject requires a rigidbody component for physics 
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    // variables
    private float horizontalInput;
    private float verticalInput;
    public float forwardSpeed = 5.0f;
    public float rotationalSpeed = 45.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // player's horizontal & vertical input is set from Unity's input manager system
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // player's horizontal & vertical movement 
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * forwardSpeed);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * rotationalSpeed);
    }
}
