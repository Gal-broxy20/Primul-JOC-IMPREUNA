using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class endlessScore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public int offset = 0;
    public TextMeshProUGUI highScore;
    public GameObject NewHighScoreText;


    public TextMeshProUGUI highScoreFall;
    public GameObject NewHighScoreTextFall;
    int suma;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScoreEndlessMode", 0).ToString();
        highScoreFall.text = highScore.text;
    }
    void Update()
    {
        suma = (int)player.position.z - offset;
        scoreText.text = suma.ToString();
        if (suma > PlayerPrefs.GetInt("HighScoreEndlessMode", 0))
        {
            PlayerPrefs.SetInt("EndlessHighScoreDiff", PlayerPrefs.GetInt("EndlessDiff", 70));
            PlayerPrefs.SetInt("HighScoreEndlessMode", suma);
            highScore.text = suma.ToString();
            highScoreFall.text = suma.ToString();
            NewHighScoreText.SetActive(true);
            NewHighScoreTextFall.SetActive(true);
        }

    }
}
