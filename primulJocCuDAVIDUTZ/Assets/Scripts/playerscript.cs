using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb; // Rigidbody = rb

    public float forwardforce = 1200f;
    public float sidewaysForce = 70f;
    //public float upForce = 5f;


    public playerscript movement;
    public AudioSource music;
    public float pitch = 0.65f;
    public GameObject fallScreen; 
    public GameObject score;

   

    

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();

        if (rb.position.x < -15f || rb.position.x > 15f || rb.position.y < 0.8f)
        {
            ///Cursor.visible = true;
            ///Cursor.lockState = CursorLockMode.None;
            movement.enabled = false;
            fallScreen.SetActive(true);
            music.pitch = pitch;
            score.SetActive(false);
            playerScript.GameHasEnded = true;
        }
        ///Cursor.lockState = CursorLockMode.Locked;
        ///Cursor.visible = false;


    }

   

      

}
