using UnityEngine;

public class Collision : MonoBehaviour
{
    public playerscript movement;

     void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
        
    }
}
