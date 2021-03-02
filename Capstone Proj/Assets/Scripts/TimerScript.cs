using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    Text TimerUI;
    private static float baseTime;
    private float minuteCount;
    private static float secondsCount;
    private float milisecondsCount;
    private void Start()
    {
       TimerUI = GetComponent<Text>();
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
        TimerUI.text = "Timer " + minuteCount + ":" + (int)secondsCount + ":" + milisecondsCount;
        if(milisecondsCount >= 100)
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
    public static void ClearTimer()
    {
        secondsCount = 0;
    }
}
