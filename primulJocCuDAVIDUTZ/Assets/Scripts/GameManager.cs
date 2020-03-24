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
        SceneManager.LoadScene("Level1");
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
        StartCoroutine(GoToLevelSelectionC());
    }
    IEnumerator GoToLevelSelectionC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        levels.SetActive(true);
    }
    public void BackFromLevelSelection()
    {
        StartCoroutine(BackFromLevelSelectionC());
    }
    IEnumerator BackFromLevelSelectionC()
    {
        yield return new WaitForSeconds(0.25f);
        levels.SetActive(false);
        menu.SetActive(true);
    }
    
    public void GoToSettings()
    {
        StartCoroutine(GoToSettingsC());
    }

    IEnumerator GoToSettingsC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        settings.SetActive(true);

    }
    
    public void BackFromSettings()
    {
        StartCoroutine(BackFromSettingsC());
    }

    IEnumerator BackFromSettingsC()
    {
        yield return new WaitForSeconds(0.25f);
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
        sceneIndex = PlayerPrefs.GetInt("Progress");
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        yield return new WaitForSeconds(0.25f);
        if (DarkTheme)
        {
            darkLoadingScreen.SetActive(true);
        } else
        {
            loadingScreen.SetActive(true);
        }
        yield return new WaitForSeconds(1.5f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
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
    public GameObject Achievements;
    public void AchievementTab ()
    {
        StartCoroutine(AchievementTabC());
    }

    IEnumerator AchievementTabC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        Achievements.SetActive(true);
    }
    public void BackFromAchievements ()
    {
        StartCoroutine(BackFromAchievementsC());
    }

    IEnumerator BackFromAchievementsC()
    {
        yield return new WaitForSeconds(0.25f);
        Achievements.SetActive(false);
        menu.SetActive(true);
    }


}