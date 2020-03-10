using UnityEngine;

public class Collision : MonoBehaviour
{
    public Playerscript movement;

     void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            return;
        }
        movement.enabled = false;
    }
}
