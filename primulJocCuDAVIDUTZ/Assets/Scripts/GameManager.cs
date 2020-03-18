using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject completelevelUI;
    bool GameHasEnded = false;
    public GameObject score;

    public void CompleteLevel()
    {
        if (GameHasEnded == false)
        {
            completelevelUI.SetActive(true);
            score.SetActive(false);
        }
    }

    public float restartDelay = 0f;
    public void Endgame()
    {
        if (GameHasEnded == false)
            GameHasEnded = true;
        Invoke("Restart", restartDelay);

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadLevel1()
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

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }


    public GameObject loadingScreen;
    public GameObject darkLoadingScreen;
    public Slider slider;
    public Text loadProgress;
    public void Play(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        if (DarkTheme)
        {
            darkLoadingScreen.SetActive(true);
        } else
        {
            loadingScreen.SetActive(true);
        }
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            loadProgress.text = progress * 100f + "%";
            yield return null;
        }
    }
    public GameObject switchtodark;
    public GameObject switchtolight;
    public bool DarkTheme = false;
    public void GoDark ()
    {
        if (!DarkTheme)
        {
            switchtodark.SetActive(true);
            switchtolight.SetActive(false);
            DarkTheme = true;
        }

    }
    public void GoLight ()
    {
        if (DarkTheme)
        {
            switchtolight.SetActive(true);
            switchtodark.SetActive(false);
            DarkTheme = false;
        }
    }
}