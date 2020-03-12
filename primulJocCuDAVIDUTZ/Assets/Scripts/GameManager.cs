using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject completelevelUI;
    bool GameHasEnded = false;
    
    public void CompleteLevel () 
    {
        if(GameHasEnded == false)
            completelevelUI.SetActive(true);
    }

    public float restartDelay = 1f;
    public void Endgame ()
    {
        if (GameHasEnded == false) 
        GameHasEnded = true;
        Invoke("Restart", restartDelay);
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
