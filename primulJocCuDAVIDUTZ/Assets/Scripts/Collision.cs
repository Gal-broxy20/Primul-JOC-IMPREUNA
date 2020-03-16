using UnityEngine;
using UnityEngine.Audio;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
    public AudioSource crashsound;
    public AudioSource music;
    public float pitch;
    
     void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
            crashsound.Play();
            music.pitch = pitch;
        }
         
       
    }
        
}

