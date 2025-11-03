using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed = 10;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float  forwardInput;
    public GameObject spherePrefab; 

    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");
       
        //Move the vehicle forward bassed on vertical 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car bassed on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput* Time.deltaTime);

           if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(spherePrefab, transform.position + Vector3.up * 1.1f, transform.rotation); 
        }
    }
}
