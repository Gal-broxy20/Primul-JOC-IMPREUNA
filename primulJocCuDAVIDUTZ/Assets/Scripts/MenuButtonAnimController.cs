using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
        } else
        {
            animator.SetBool("DarkTheme", false);
        }
    }
}
