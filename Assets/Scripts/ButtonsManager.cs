using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    public GameObject options;
    public GameObject levelselection;
    public GameObject settings;
    public void GoToLevelSelection()
    {
        options.SetActive(false);
        levelselection.SetActive(true);
    }
    public void BackFromLevelSelection()
    {
        options.SetActive(true);
        levelselection.SetActive(false);
    }
    public void Settings()
    {
        options.SetActive(false);
        settings.SetActive(true);
    }
    public void BackFromSettings()
    {
        options.SetActive(true);
        settings.SetActive(false);
    }
    public void goback()
    {
        SceneManager.LoadScene("Meniu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    } 
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    } 
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
}
