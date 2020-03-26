using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Audio;
public class scortrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject skiptext;
    public TutorialMovement movement;
    private void Start()
    {
        if (PlayerPrefs.GetInt("HasPlayedTutorial", 0) == 1)
            skiptext.SetActive(true);

    }

    public Animator animator;
    private void Update()
    {
        if(PlayerPrefs.GetInt("HasPlayedTutorial", 0) == 1 && Input.GetKeyDown(KeyCode.Escape)) {
            animator.SetBool("ESC", true);
            StartCoroutine("LoadMenu");
        }
    }

    public AudioSource source;
    IEnumerator LoadMenu()
    {
        movement.enabled = false;
        while(source.volume > 0f)
        {
            source.volume -= Time.deltaTime / 0.5f;
            yield return null;
        }
        source.Stop();
        yield return new WaitForSeconds(0.5f);
        gameManager.LoadMenu();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameManager.LoadNextLevel();
        PlayerPrefs.SetInt("HasPlayedTutorial", 1);
    }

    
}
