using UnityEngine;

public class ResumeScript : MonoBehaviour
{
    public GameObject ResumeCountdown;
    public AudioSource player;

    public void Resume()
    {
            PauseMenu pauseScript = GameObject.Find("Canvas").GetComponent<PauseMenu>();
            Time.timeScale = 1f;
            player.pitch = 1f;
        pauseScript.GameIsPaused = false;
            ResumeCountdown.SetActive(false);
    }
}
