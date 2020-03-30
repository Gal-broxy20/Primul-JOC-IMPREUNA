using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessCamandLight : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 100f;
    public Vector3 offset;
    public Transform sun;
    public Material lightMat;
    public Material normalMat;
    public Material normalCube;
    public GameObject cube;
    //public Material stars;
    public Material sky;
    public Light SunLi;
    public float SunlightIntensity = 0.8f;
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        if (sun.position.y <= -2)
        {
            // Set the fog color to be blue
            RenderSettings.fogColor = Color.black;
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Obstacle"))
            {

                ObjectFound.GetComponent<Renderer>().material = lightMat;
            }
            cube.GetComponent<Renderer>().material = lightMat;
            //RenderSettings.skybox = stars;

        }
        else if (sun.position.y >= 0)
        {
            RenderSettings.fogColor = new Color(0.8274511f, 0.8274511f, 0.8078432f, 1f);
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Obstacle"))
            {

                ObjectFound.GetComponent<Renderer>().material = normalMat;
            }
            cube.GetComponent<Renderer>().material = normalCube;
            RenderSettings.skybox = sky;
        }

        if(sun.position.y < 30)
        {
            SunLi.intensity = SunlightIntensity;
        }
        else
        {
            SunLi.intensity = 1f;
        }
    }
}
