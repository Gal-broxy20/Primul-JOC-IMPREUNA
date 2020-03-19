using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public  bool GameIsPaused = false;

    

    public GameObject pauseMenuUI;

    public AudioSource player;
    
    void Update()
    {
        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();

        if(Input.GetKeyDown(KeyCode.Escape) && playerScript.GameHasEnded == false && QuitPanelIsOpen == false)
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public GameObject ResumeCountdown;
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        ResumeCountdown.SetActive(true);
        
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        player.pitch = 0f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void quitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public GameObject quitPanel;
    public bool QuitPanelIsOpen = false;
    public void quitPanelOpen()
    {
        quitPanel.SetActive(true);
        QuitPanelIsOpen = true;
    }
    public void quitPanelClose()
    {
        quitPanel.SetActive(false);
        QuitPanelIsOpen = false;
    }
}
