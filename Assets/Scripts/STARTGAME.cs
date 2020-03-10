using UnityEngine.SceneManagement;
using UnityEngine;

public class STARTGAME : MonoBehaviour
{
    public GameObject meniu;
    public GameObject optiuni;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Options()
    {
        meniu.SetActive(false);
        optiuni.SetActive(true);
    }
    
}
