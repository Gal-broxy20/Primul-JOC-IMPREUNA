using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scortrigger : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider other)
    {
        gameManager.LoadNextLevel();
    }

    
}
