using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAfterCrash : MonoBehaviour
{
    // Start is called before the first frame update
    public Text CrASHScore;
    public Text slevel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrASHScore.text = slevel.text;
    }
}
