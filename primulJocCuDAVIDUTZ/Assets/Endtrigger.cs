using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Level Finished");
    }
}
