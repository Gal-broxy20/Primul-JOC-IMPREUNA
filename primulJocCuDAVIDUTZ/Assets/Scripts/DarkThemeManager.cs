using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DarkThemeManager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Levels;
    public GameObject Settings;
    
    
    public void GoToLevelSelection()
    {
        Menu.SetActive(false);
        Levels.SetActive(true); 
    }
    public void BackFromLevelSelection()
    {
        Levels.SetActive(false);
        Menu.SetActive(true);
    }
    public void GoToSettings()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }
    public void BackFromSettings()
    {
        Settings.SetActive(false);
        Menu.SetActive(true);
        
    }

}
