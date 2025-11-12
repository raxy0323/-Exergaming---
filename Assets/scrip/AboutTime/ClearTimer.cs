using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimer : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    public static bool stop = true;
    public static float clearTime;
    public static bool stop1 = true;
    public static float takeTime;

    public static void StartTimeCounting()
    {
        stop = false;
    }
    public static void StopTimeCounting()
    {
        stop = true;
    }

    public static void InitTime()
    {
        takeTime = 0;
    }
    public static void ResetTime()
    {
        clearTime = 0;
    }

    void FixedUpdate()
    {
        UpdateClear();
        UpdateTake();
        timeText.text = System.TimeSpan.FromSeconds(clearTime).ToString(format: @"mm\:ss\:ff");
    }
    void UpdateClear()
    {
        if (stop) return;
        clearTime += Time.fixedDeltaTime;//fixedDeltaTime == 0.02
    }
    void UpdateTake()
    {
        if (stop1) return;
        takeTime += Time.fixedDeltaTime;//fixedDeltaTime == 0.02
    }
}
