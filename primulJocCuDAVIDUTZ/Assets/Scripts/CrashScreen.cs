
using UnityEngine;

public class CrashScreen : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<GameManager>().Endgame();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().LoadMenu();
        }
    }
}
