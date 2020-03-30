using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

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
    
    public void LoadEndlessMode()
    {
        SceneManager.LoadScene("Endless");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public GameObject levels;
    public GameObject menu;
    public GameObject settings;
    public GameObject darklevels;
    public GameObject darkMenu;
    public GameObject darksettings;
    public void GoToLevelSelection()
    {
        StartCoroutine(GoToLevelSelectionC());
    }
    IEnumerator GoToLevelSelectionC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        darkMenu.SetActive(false);
        darklevels.SetActive(true);
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
        darklevels.SetActive(false);
        darkMenu.SetActive(true);
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
        darkMenu.SetActive(false);
        darksettings.SetActive(true);
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
        darksettings.SetActive(false);
        darkMenu.SetActive(true);
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
    public Slider darkSlider;
    public Text darkLoadProgress;
    public GameObject lvlCompmsg;
    public void Play(int sceneIndex)
    {
        sceneIndex = PlayerPrefs.GetInt("Progress", 2);
        if (sceneIndex == 5)
        {
            lvlCompmsg.SetActive(true);
        }
        else
        {
            StartCoroutine(LoadAsynchronously(sceneIndex));

        }
        }
    

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        yield return new WaitForSeconds(0.25f);
            darkLoadingScreen.SetActive(true);
            darkMenu.SetActive(false);
            loadingScreen.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            loadProgress.text = (int) progress * 100f + "%";
            darkSlider.value = progress;
            darkLoadProgress.text = (int) progress * 100f + "%";
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
            StartCoroutine(GoDarkC());
        }
        
    }

    IEnumerator GoDarkC()
    {
        yield return new WaitForSeconds(0.3f);
        switchtodark.SetActive(true);
        switchtolight.SetActive(false);
        DarkTheme = true;
    }
    public void GoLight ()
    {
        if (DarkTheme)
        {
            StartCoroutine(GoLightC());
        }
    }
    IEnumerator GoLightC()
    {
        yield return new WaitForSeconds(0.25f);
        switchtolight.SetActive(true);
        switchtodark.SetActive(false);
        DarkTheme = false;
    }
    public GameObject Achievements;
    public GameObject DarkAchievements;
    public void AchievementTab ()
    {
        StartCoroutine(AchievementTabC());
    }

    IEnumerator AchievementTabC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        darkMenu.SetActive(false);
        Achievements.SetActive(true);
        DarkAchievements.SetActive(true);
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
        DarkAchievements.SetActive(false);
        darkMenu.SetActive(true);
    }

    public GameObject DifficultyScreen;
    public GameObject DarkDiffScreen;
    public void SelectEndlessDifficulty()
    {
        StartCoroutine("SelectEndlessDifficultyC");
    }
    IEnumerator SelectEndlessDifficultyC()
    {
        yield return new WaitForSeconds(0.25f);
        levels.SetActive(false);
        darklevels.SetActive(false);
        DarkDiffScreen.SetActive(true);
        DifficultyScreen.SetActive(true);
    }

    public void BackFromDifficultySelection()
    {
        StartCoroutine("BackFromDiffSelC");
    }
    IEnumerator BackFromDiffSelC()
    {
        yield return new WaitForSeconds(0.25f);
        levels.SetActive(true);
        darklevels.SetActive(true);
        DarkDiffScreen.SetActive(false);
        DifficultyScreen.SetActive(false);
    }

     public void SelectEasyDifficulty()
    {
        PlayerPrefs.SetInt("EndlessDiff", 75);
    }
    public void SelectMediumDifficulty()
    {
        PlayerPrefs.SetInt("EndlessDiff", 70);
    }
    public void SelectHardDifficulty()
    {
        PlayerPrefs.SetInt("EndlessDiff", 65);
    }

    public Animator animator;
    public void ResetHighScores()
    {
        animator.SetTrigger("HighReset");
        animator.SetTrigger("DarkHighReset");
        PlayerPrefs.SetInt("HighScoreLvl1", 0);
        PlayerPrefs.SetInt("HighScoreLvl3", 0);
        PlayerPrefs.SetInt("HighScoreLvl2", 0);
        PlayerPrefs.SetInt("HighScoreEndlessMode", 0);
        PlayerPrefs.SetInt("EndlessHighScoreDiff", 0);
    }
}