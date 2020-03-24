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
            animator.SetBool("2ndButton", false);
        } else
        {
            animator.SetBool("2ndButton", true);
            animator.SetBool("ButtonPress", false);
        }
    }
}
