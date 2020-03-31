using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

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
        PauseMenu script = GameObject.Find("Canvas").GetComponent<PauseMenu>();

        timer += Time.deltaTime;
        if(timer >= newClip + 1)
        {
            newCLIP();
            timer = 0;
        }
        if(Input.GetKeyDown(KeyCode.E) && script.GameIsPaused == false)
        {
            SkipSong();
            timer = 0;
        }
    }

    int clipNum;
    int prevClipNum;
    public TextMeshProUGUI songName;
    public GameObject songNameImage;
    private bool AnimationIsPlaying = false;
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
            songName.text = clips[clipNum].name;
            songNameImage.SetActive(true);
            StartCoroutine("SongNameC");

        }
        newClip = clips[clipNum].length;
    }

    void SkipSong()
    {
        if (!AnimationIsPlaying)
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
            songName.text = clips[clipNum].name;
            songNameImage.SetActive(true);
            StartCoroutine("SongNameC");
        }
    }
    IEnumerator SongNameC()
    {
        AnimationIsPlaying = true;
        yield return new WaitForSeconds(2.3f);
        songNameImage.SetActive(false);
        AnimationIsPlaying = false;
    }
}
