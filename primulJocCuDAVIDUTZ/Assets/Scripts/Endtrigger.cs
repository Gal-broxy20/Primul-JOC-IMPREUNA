using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    public playerscript stop;
    int index;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Collision script = GameObject.Find("Player").GetComponent<Collision>();
        if (script.GameHasEnded == false)
        {
            Debug.Log("Level Finished");
            gameManager.CompleteLevel();
            stop.enabled = false;
            index = SceneManager.GetActiveScene().buildIndex;
        }
    }
}
