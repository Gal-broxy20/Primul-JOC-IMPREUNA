using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeScene : MonoBehaviour
{
 
    public GameObject image;
    public void SetImageInactive()
    {
        image.SetActive(false);
    } 
    public void SetImageActive()
    {
        image.SetActive(true);
    }
    
}
