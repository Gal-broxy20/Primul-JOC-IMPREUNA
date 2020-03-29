using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platfrmSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float offset;
    public float startTimeBtwSpawn;
    public float TimeBtwSpawn;
    public GameObject platforma;

    void Start()
    {
        StartCoroutine("MoveSpawner");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(TimeBtwSpawn <= 0)
        {
            Instantiate(platforma, transform.position, Quaternion.identity);
            TimeBtwSpawn = startTimeBtwSpawn;
        } else
        {
            TimeBtwSpawn -= Time.deltaTime;
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
