using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float offset = 5f;
    float suma;
    void Update()
    {
        suma = player.position.z - offset;
        scoreText.text = suma.ToString("0");
    }
}
