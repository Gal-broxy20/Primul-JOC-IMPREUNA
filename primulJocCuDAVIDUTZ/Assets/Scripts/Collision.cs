using UnityEngine;

public class Collision : MonoBehaviour
{
    public playerscript movement;
    public GameManager GM; // GM - game manager
    bool UIFalse = false;
    
     void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;         
            
            UIFalse = true;

            if (UIFalse == true)
            {
                FindObjectOfType<GameManager>().Endgame();
            }
            
        }
        
    }
}
