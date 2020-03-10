using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
   
     void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacol")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}    
