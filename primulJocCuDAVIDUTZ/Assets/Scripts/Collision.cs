using UnityEngine;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag = "Obstacle")
        {
            return;
        }
        movement.enabled = false;
    }
}
