using UnityEngine;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
     void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
        
    }
}
