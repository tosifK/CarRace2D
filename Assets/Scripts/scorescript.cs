using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorescript : MonoBehaviour
{
    public int i;
    public Text scoring;
    float score;
    public int maxscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * 3;
        scoring.text = "Score: " + (int)score;
        if (PlayerPrefs.GetInt("BestScore") < score)
        {
            PlayerPrefs.SetInt("BestScore: ", (int)score);
        }
        if (score>maxscore)
        {
            SceneManager.LoadScene(i);
            score = maxscore;
        }
    }
}
