using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scortrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void Start()
    {
        if (PlayerPrefs.GetInt("HasPlayedTutorial", 0) == 1)
            gameManager.LoadNextLevel();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameManager.LoadNextLevel();
        PlayerPrefs.SetInt("HasPlayedTutorial", 1);
    }

    
}
