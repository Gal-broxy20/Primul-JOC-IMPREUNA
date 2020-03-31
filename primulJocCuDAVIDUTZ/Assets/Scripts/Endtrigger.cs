﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtrigger : MonoBehaviour
{
    public GameManager gameManager;
    public playerscript stop;
    int index;

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("Level Finished");
        gameManager.CompleteLevel();
        stop.enabled = false;
        index = SceneManager.GetActiveScene().buildIndex;
    }
}
