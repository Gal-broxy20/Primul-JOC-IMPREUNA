using UnityEngine;
using UnityEngine.UI;

public class scortrigger : MonoBehaviour
{
    public GameObject score;
    private void OnTriggerEnter(Collider other)
    {
        score.SetActive(true);

    }
}
