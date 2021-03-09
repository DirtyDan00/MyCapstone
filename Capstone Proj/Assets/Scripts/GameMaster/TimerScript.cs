using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;
using UnityEngine.UI;
using TMPro;
public class TimerScript : MonoBehaviour
{
    public TMP_Text TimerUI;
    public static Text finalTimerUI;
    private static float baseTime;
    private float minuteCount;
    public static float secondsCount;
    private float milisecondsCount;
    private void Start()
    {
        TimerUI = GetComponent<TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {
        Timer();
        milisecondsCount = Time.deltaTime * 1000;

    }

    private void Timer()
    {
        secondsCount += Time.deltaTime;
        TimerUI.text = "Timer " + (minuteCount + ":" + (int)secondsCount).ToString();
        if (milisecondsCount >= 100)
        {
            secondsCount++;
            milisecondsCount = 0;
        }
        else if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }
    public static void finalTimeDisplay()
    {
        secondsCount = PlayerPrefs.GetFloat("Timer", 0);
        finalTimerUI.text = "Final Time" + secondsCount;

    }
    public static void ClearTimer()
    {
        secondsCount = 0;
    }
}
