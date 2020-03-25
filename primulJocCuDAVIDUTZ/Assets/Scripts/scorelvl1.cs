using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLVL1 : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int offset = 0;
    public Text highScore;
    public GameObject NewHighScoreText;
    int suma;
    public GameObject FallNewHighScore;
    public Text FallHighScore;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScoreLvl1", 0).ToString();
        FallHighScore.text = highScore.text;
    }
    void Update()
    {
        suma = (int)player.position.z - offset;
        scoreText.text = suma.ToString();
        if (suma > PlayerPrefs.GetInt("HighScoreLvl1"))
        {

            PlayerPrefs.SetInt("HighScoreLvl1", suma);
            highScore.text = suma.ToString();
            FallHighScore.text = suma.ToString();
            NewHighScoreText.SetActive(true);
            FallNewHighScore.SetActive(true);
        }

    }
}
