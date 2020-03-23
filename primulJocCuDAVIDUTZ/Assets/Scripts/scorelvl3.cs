using UnityEngine;
using UnityEngine.UI;

public class scorelvl3 : MonoBehaviour
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
        highScore.text = PlayerPrefs.GetInt("HighScoreLvl3", 0).ToString();
        highScoreFall.text = highScore.text;
    }
    void Update()
    {
        suma = (int)player.position.z - offset;
        scoreText.text = suma.ToString();
        if (suma > PlayerPrefs.GetInt("HighScoreLvl3", 0))
        {

            PlayerPrefs.SetInt("HighScoreLvl3", suma);
            highScore.text = suma.ToString();
            highScoreFall.text = suma.ToString();
            NewHighScoreText.SetActive(true);
            NewHighScoreTextFall.SetActive(true);
        }

    }
}
