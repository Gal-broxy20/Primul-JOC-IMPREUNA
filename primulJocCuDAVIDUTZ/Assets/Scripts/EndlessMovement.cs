using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public Rigidbody rb;
    public float sidewaysForce;
    public float forwardforce = 1200f;
    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardforce * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
