using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkThemeManager : MonoBehaviour
{
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

    public GameObject Achievements;
    public void AchievementTab()
    {
        StartCoroutine(AchievementTabC());
    }

    IEnumerator AchievementTabC()
    {
        yield return new WaitForSeconds(0.25f);
        menu.SetActive(false);
        Achievements.SetActive(true);
    }
    public void BackFromAchievements()
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
