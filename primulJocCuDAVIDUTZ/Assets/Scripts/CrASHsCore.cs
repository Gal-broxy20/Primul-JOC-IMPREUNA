using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrASHsCore : MonoBehaviour
{
    public Text scoreLevel;
    public Text crashscore;
    void Update()
    {
        crashscore.text = scoreLevel.text;
    }
}
