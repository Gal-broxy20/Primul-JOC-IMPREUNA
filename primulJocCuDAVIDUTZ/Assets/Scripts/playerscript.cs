
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Rigidbody rb; // Rigidbody = rb

    public float forwardforce = 700f;
    public float sidewaysForce = 500f;
    public float upForce = 10f;
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
        if (Input.GetKey("space"))
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
    }
}
