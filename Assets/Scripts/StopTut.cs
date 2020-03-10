using UnityEngine;

public class StopTut : MonoBehaviour
{
    public GameManager gamemanager;

    public void OnTriggerEnter()
    {
        gamemanager.notut();
    }
}
