using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    Text currentScore;
    public static int scoreValue;
    private void Start()
    {
        currentScore = GetComponent<Text>();
    }
    void Update()
    {
        currentScore.text = "Score: " + scoreValue;
    }
    public static void ClearScore()
    {
        scoreValue = 0;
    }

}
