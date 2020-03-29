using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endlessScore : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int offset = 0;
    public Text highScore;
    public GameObject NewHighScoreText;


    public Text highScoreFall;
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

            PlayerPrefs.SetInt("HighScoreEndlessMode", suma);
            highScore.text = suma.ToString();
            highScoreFall.text = suma.ToString();
            NewHighScoreText.SetActive(true);
            NewHighScoreTextFall.SetActive(true);
        }

    }
}
