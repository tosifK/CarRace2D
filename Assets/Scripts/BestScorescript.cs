using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScorescript : MonoBehaviour
{
    public Text Bestscoring;
    float bestscore;
    // Start is called before the first frame update
    void Start()
    {
        Bestscoring.text = "BestScore: "+ PlayerPrefs.GetInt("BestScore");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
