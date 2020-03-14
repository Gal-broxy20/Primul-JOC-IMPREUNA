﻿using UnityEngine;
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
    public void LoadLevel1  ()
    {
        SceneManager.LoadScene("Tutorial + Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public GameObject levels;
    public GameObject menu;
    public GameObject settings;
    public void GoToLevelSelection()
    {
        menu.SetActive(false);
        levels.SetActive(true);
    }
    public void BackFromLevelSelection()
    {
        levels.SetActive(false);
        menu.SetActive(true);
    }
    public void GoToSettings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
    }
    public void BackFromSettings()
    {
        settings.SetActive(false);
        menu.SetActive(true);
    }
}
