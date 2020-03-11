using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Playerscript movement;

     void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
        
    }
}
