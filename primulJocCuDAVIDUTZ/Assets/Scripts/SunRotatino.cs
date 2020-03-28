using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotatino : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float sunspeed = 5f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, sunspeed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
