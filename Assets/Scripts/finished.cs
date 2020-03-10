using UnityEngine;
using UnityEngine.SceneManagement;

public class finished : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void GOTOMENU()
    {
        SceneManager.LoadScene("Meniu");
    }
}
