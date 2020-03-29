﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;
    public float offset = 80f;
    



    private void Start()
    {
        StartCoroutine("MoveSpawner");
        
    }

    void FixedUpdate()
    {

        
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
    IEnumerator MoveSpawner()
    {
        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();
        while (playerScript.GameHasEnded == false)
        {
            yield return new WaitForSeconds(startTimeBtwSpawn);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
        }
    }
}
