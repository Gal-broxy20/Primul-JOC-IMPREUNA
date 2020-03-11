using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completelevelUI;
    bool GameHasEnded = false;
    public void CompleteLevel () 
    {
    completelevelUI.SetActive(true);
    }

    public float restartDelay = 2f;
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
}
