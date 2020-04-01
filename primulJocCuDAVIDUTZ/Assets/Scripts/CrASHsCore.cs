using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CrASHsCore : MonoBehaviour
{
    public TextMeshProUGUI scoreLevel;

    public TextMeshProUGUI crashscore;
    void Start()
    {
        crashscore.text = scoreLevel.text;

    }
    private void Update()
    {
        crashscore.text = scoreLevel.text;
    }
}
