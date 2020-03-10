using UnityEngine;

public class tutorialtrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.tutorialdisplay();
    }
}
