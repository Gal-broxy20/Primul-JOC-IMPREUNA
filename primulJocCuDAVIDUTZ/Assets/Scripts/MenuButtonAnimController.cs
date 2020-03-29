using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuButtonAnimController : MonoBehaviour
{
    public Animator animator;
    public void ButtonAnimation()
    {
        if(!animator.GetBool("ButtonPress"))
        {
            animator.SetBool("ButtonPress", true);
        } else
        {
            animator.SetBool("ButtonPress", false);
        }
    }
    public void ThemeButtonPressed()
    {
        if(!animator.GetBool("DarkTheme"))
        {
            animator.SetBool("DarkTheme", true);

        }
        else { 
            animator.SetBool("DarkTheme", false);
        }
    }

    public TextMeshProUGUI EndlesshighScoreinMenu;
    public TextMeshProUGUI DarkEndlesshighScoreinMenu;

    public void FixedUpdate()
    {
        EndlesshighScoreinMenu.text = PlayerPrefs.GetInt("HighScoreEndlessMode", 0).ToString();
        DarkEndlesshighScoreinMenu.text = PlayerPrefs.GetInt("HighScoreEndlessMode", 0).ToString();
    }
}
