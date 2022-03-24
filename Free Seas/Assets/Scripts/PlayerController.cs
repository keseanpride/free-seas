using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    // variables
    private float horizontalInput;
    public float horizontalSpeed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // player's horizontal input is set from Unity's input manager system
        horizontalInput = Input.GetAxis("Horizontal");

        // player's horizontal movement 
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalSpeed);
    }
}
