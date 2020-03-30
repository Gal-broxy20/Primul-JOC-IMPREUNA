using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MenuButtonAnimController : MonoBehaviour
{
    public Animator animator;
    public GameObject easy;
    public GameObject medium;
    public GameObject hard;
    public GameObject darkeasy;
    public GameObject darkmedium;
    public GameObject darkhard;
    public void Start()
    {
        int HighDiff = PlayerPrefs.GetInt("EndlessHighScoreDiff", 0);
        if(HighDiff == 65)
        {
            hard.SetActive(true);
            darkhard.SetActive(true);
        }
        if (HighDiff == 70)
        {
            medium.SetActive(true);
            darkmedium.SetActive(true);
        }
        if (HighDiff == 75)
        {
            easy.SetActive(true);
            darkeasy.SetActive(true);
        }

    }
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
