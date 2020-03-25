using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMovement : MonoBehaviour
{
    public Rigidbody rb; // Rigidbody = rb

    public float forwardforce = 1200f;
    public float sidewaysForce = 70f;
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

        if(rb.position.x < -15f || rb.position.x > 15f || rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
