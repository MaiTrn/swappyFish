using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    private int _CurrentScore = 0;
    private float time = 0f;
    public void IncrementScore()
    {
        _CurrentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + _CurrentScore.ToString();
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            IncrementScore();
            time = 0f;
        }
            
    }
}
