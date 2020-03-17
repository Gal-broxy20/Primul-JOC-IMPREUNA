using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialcollison : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
    public AudioSource crashsound;
    public AudioSource music;
    public float pitch;
    

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obstacle")

        {
            movement.enabled = false;
            //crashScreen.SetActive(true);
            crashsound.Play();
            music.pitch = pitch;
            FindObjectOfType<GameManager>().Endgame();
        }


    }
}
