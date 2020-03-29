using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public float smoothSpeed = 20f;
    public Vector3 offset;
    public Transform sun;
    public Material lightMat;
    public Material normalMat;
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;

        if(sun.position.y <= -2)
        {
            // Set the fog color to be blue
            RenderSettings.fogColor = Color.black;
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Obstacle"))
            {
                
                ObjectFound.GetComponent<Renderer>().material = lightMat;
            }

        }
        else if(sun.position.y >=0)
        {
            RenderSettings.fogColor = new Color(0.8274511f, 0.8274511f, 0.8078432f, 1f);
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Obstacle"))
            {

                ObjectFound.GetComponent<Renderer>().material = normalMat;
            }
        }
    }
}
