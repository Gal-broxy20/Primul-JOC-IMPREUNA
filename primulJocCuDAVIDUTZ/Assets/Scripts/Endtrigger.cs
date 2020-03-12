using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    public playerscript stop;
    
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("Level Finished");
        gameManager.CompleteLevel();
        stop.enabled = false;       
    }
}
