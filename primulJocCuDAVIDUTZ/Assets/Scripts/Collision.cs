using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
    public AudioSource crashsound;
    public AudioSource music;
    public float pitch;
    public GameObject crashScreen;
    public GameObject score;
    public bool GameHasEnded = false;
    
     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obstacle")

        {
            movement.enabled = false;
            crashScreen.SetActive(true);
            crashsound.Play();
            music.pitch = pitch;
            score.SetActive(false);
            GameHasEnded = true;
        }
         
       
    }
        
}

