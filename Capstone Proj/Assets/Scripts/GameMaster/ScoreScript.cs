using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    TMP_Text currentScore;
    public static TMP_Text finalScoreUI;
    public static int scoreValue;
    private void Start()
    {
        currentScore = GetComponent<TMP_Text>();
    }
    void Update()
    {
        currentScore.text = "Score: " + scoreValue.ToString();
    }
    public static void finalScoreDisplay()
    {
        finalScoreUI.text = "Final Score" + scoreValue.ToString();
    }
    public static void ClearScore()
    {
        scoreValue = 0;
    }

}
