using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obstacle;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    public Transform player;
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        transform.position = desiredPosition;
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            startTimeBtwSpawn -= decreaseTime;
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
