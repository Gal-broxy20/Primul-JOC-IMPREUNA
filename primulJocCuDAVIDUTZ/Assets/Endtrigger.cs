using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public playerscript stop;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Level Finished");
        stop.enabled = false;
    }
}
