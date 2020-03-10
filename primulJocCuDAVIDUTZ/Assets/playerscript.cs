using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb; // Rigidbody = rb

    //Update is called once per frame.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.fixedDeltaTime);
    }
}
