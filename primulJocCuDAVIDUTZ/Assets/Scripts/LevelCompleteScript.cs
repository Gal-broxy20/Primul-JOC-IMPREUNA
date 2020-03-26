using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteScript : MonoBehaviour
{
    private void Start()
    {
        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();
        playerScript.GameHasEnded = true;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<GameManager>().LoadNextLevel();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().LoadMenu();
        }
    }
}
