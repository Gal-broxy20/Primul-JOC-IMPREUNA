using UnityEngine;
using UnityEngine.UI;

public class scorelvl1 : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int offset = 0;
    public Text highScore;
    public GameObject NewHighScoreText;
    int suma;
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScoreLvl1", 0).ToString();
    }
    void Update()
    {
        suma = (int)player.position.z - offset;
        scoreText.text = suma.ToString();
        if (suma > PlayerPrefs.GetInt("HighScoreLvl1", 0))
        {

            PlayerPrefs.SetInt("HighScoreLvl1", suma);
            highScore.text = suma.ToString();
            NewHighScoreText.SetActive(true);
        }

    }
}
