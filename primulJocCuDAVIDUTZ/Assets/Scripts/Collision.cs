using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
    public AudioSource crashsound;
    public AudioSource music;
    public float pitch;
    public GameObject crashScreen;
    
     void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            crashScreen.SetActive(true);
            crashsound.Play();
            music.pitch = pitch;
        }
         
       
    }
        
}

