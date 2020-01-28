using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //  input --> connecting keyboard movement to the location of the ball 
        float moveVertical = Input.GetAxis("Vertical");
            
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= .5f)
        {
            Vector3 jump = new Vector3(0.0f, 150.0f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);
        }
        
        rb.AddForce(movement * speed);
    }
}
