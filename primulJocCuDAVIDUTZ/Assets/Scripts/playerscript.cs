
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb; // Rigidbody = rb

    public float forwardforce = 700f;
    public float sidewaysForce = 50f;
    //public float upForce = 5f;


    public playerscript movement;
    public AudioSource music;
    public float pitch = 0;
    public GameObject fallScreen; 
    public GameObject score;

   

    

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

        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();

        if (rb.position.x < -10f || rb.position.x > 10f || rb.position.y < -2f)
        {
            movement.enabled = false;
            fallScreen.SetActive(true);
            music.pitch = pitch;
            score.SetActive(false);
            playerScript.GameHasEnded = true;
        }
        
            
    }

   

      

}
