using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn = 0f;
    public float startTimeBtwSpawn;
    public float offset;
    



    private void Start()
    {
        StartCoroutine("MoveSpawner");
        offset = PlayerPrefs.GetInt("EndlessDiff", 70);
        
    }

    void FixedUpdate()
    {
        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();

        if (timeBtwSpawn <= 0 && playerScript.GameHasEnded == false)
        {
            
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        } else if (timeBtwSpawn > 0 && playerScript.GameHasEnded == false)
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
    IEnumerator MoveSpawner()
    {
        Collision playerScript = GameObject.Find("Player").GetComponent<Collision>();
        while (playerScript.GameHasEnded == false)
        {
            
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
            yield return new WaitForSeconds(startTimeBtwSpawn);
        }
    }
}
