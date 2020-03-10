using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRot : MonoBehaviour
{
    public Transform tr;
    void FixedUpdate()
    {
        tr.Rotate(0, 0, 0);
    }
}
