using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public float speed;
    public Rigidbody rb;
    public float sidewaysForce;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
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
