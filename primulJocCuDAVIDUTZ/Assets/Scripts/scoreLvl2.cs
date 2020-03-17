using UnityEngine;
using UnityEngine.UI;

public class scoreLvl2 : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int offset = 0;
    public Text highScore;
    public GameObject NewHighScoreText;
    int suma;
     void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScoreLvl2", 0).ToString();
    }
    void Update()
    {
        suma = (int)player.position.z - offset;
        scoreText.text = suma.ToString();
        if(suma > PlayerPrefs.GetInt("HighScoreLvl2", 0))
        {
            
            PlayerPrefs.SetInt("HighScoreLvl2", suma);
            highScore.text = suma.ToString();
            NewHighScoreText.SetActive(true);
            
        }
        
    }
}
