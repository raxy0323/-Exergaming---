using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class ScoreCounting : MonoBehaviour
{
    public static float timenumber = 1.0f;

    public static float spendTime;
    public static void addScore(float num)
    {
        spendTime = num - 3;
        if (spendTime < 5)
        {
            timenumber = 2;
            Stand.score += 10000 * timenumber;
        }
        else if (spendTime >= 5 && spendTime < 7)
        {
            timenumber = 1.5f;
            Stand.score += 10000 * timenumber;
        }
        else if (spendTime >= 7 && spendTime < 10)
        {
            timenumber = 1.3f;
            Stand.score += 10000 * timenumber;
        }
        else if (spendTime >= 10 && spendTime <= 15)
        {
            timenumber = 1;
            Stand.score += 10000 * timenumber;
        }
        else if (spendTime >= 15 && spendTime < 20)
        {
            timenumber = 0.8f;
            Stand.score += 10000 * timenumber;
        }
        else if (spendTime >= 20)
        {
            timenumber = 0;
            Stand.score += 10000 * timenumber;
        }
    }
}
