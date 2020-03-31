using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EndlessMusic : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;
    public float timer;
    public float newClip;
   

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= newClip + 1)
        {
            newCLIP();
            timer = 0;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            SkipSong();
            timer = 0;
        }
    }

    int clipNum;
    int prevClipNum;
    void newCLIP()
    {
        clipNum = Random.Range(0, clips.Length);
        while (prevClipNum == clipNum)
        {
            clipNum = Random.Range(0, clips.Length);
        }
        prevClipNum = clipNum;
        if(!source.isPlaying)
        {
            source.loop = true;
            source.PlayOneShot(clips[clipNum]);
        }
        newClip = clips[clipNum].length;
    }

    void SkipSong()
    {
        clipNum = Random.Range(0, clips.Length);
        while (prevClipNum == clipNum)
        {
            clipNum = Random.Range(0, clips.Length);
        }
        prevClipNum = clipNum;
        source.Stop();
        source.PlayOneShot(clips[clipNum]);
        newClip = clips[clipNum].length;
    }
}
