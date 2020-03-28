using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;
    public float difBtwObst;
    public float zet;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(0f, 1.5f, zet);
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            startTimeBtwSpawn -= decreaseTime;
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
