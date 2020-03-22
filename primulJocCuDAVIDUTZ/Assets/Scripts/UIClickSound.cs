using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClickSound : MonoBehaviour
{
    public AudioSource uiclick;
    public void PlaySoundOnUIClick()
    {
        uiclick.Play();

    }
}
