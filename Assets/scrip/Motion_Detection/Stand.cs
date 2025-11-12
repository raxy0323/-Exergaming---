using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class Stand : MonoBehaviour
{
    public TextMeshProUGUI StandText;
    public TextMeshProUGUI ActionText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreNumText;
    public TextMeshProUGUI type_counting;
    public TextMeshProUGUI PositionText;
    public TextMeshProUGUI switcherText;
    public string sceneToLoad; // 指定要加载的场景名称

    public float updateInterval = 1.0f;

    public int range = 3;
    public int onother_range = 5;
    public static float type = 0;
    public static int switcher = 8;
    public static float spendTime = 0f;
    public static float score = 0; //set score as zero
    public static int action = 0;
    public float time;
    public static int st_count = 0;

    GameObject MNose0;
    GameObject MMid1;
    GameObject RShoulder2;
    GameObject RElbow3;
    GameObject RWrist4;
    GameObject LShoulder5;
    GameObject LElbow6;
    GameObject LWrist7;
    GameObject MAss8;
    GameObject RAss9;
    GameObject RKnee10;
    GameObject RFoot11;
    GameObject LAss12;
    GameObject LKnee13;
    GameObject LFoot14;
    GameObject REye15;
    GameObject LEye16;
    GameObject REar17;
    GameObject LEar18;
    GameObject LToe19;
    GameObject LSToe20;
    GameObject LHeel21;
    GameObject RToe22;
    GameObject RSToe23;
    GameObject RHeel24;


    void RestartInit()
    {
        type = 0;
        action = 0;
        switcher = 0;
        ClearTimer.ResetTime();
        ClearTimer.InitTime();
        ClearTimer.stop = true;
        ClearTimer.stop1 = true;
    }
    void InitObject()
    {
        MNose0 = GameObject.Find("MNose0");
        MMid1 = GameObject.Find("MMid1");
        RShoulder2 = GameObject.Find("RShoulder2");
        RElbow3 = GameObject.Find("RElbow3");
        RWrist4 = GameObject.Find("RWrist4");
        LShoulder5 = GameObject.Find("LShoulder5");
        LElbow6 = GameObject.Find("LElbow6");
        LWrist7 = GameObject.Find("LWrist7");
        MAss8 = GameObject.Find("MAss8");
        RAss9 = GameObject.Find("RAss9");
        RKnee10 = GameObject.Find("RKnee10");
        RFoot11 = GameObject.Find("RFoot11");
        LAss12 = GameObject.Find("LAss12");
        LKnee13 = GameObject.Find("LKnee13");
        LFoot14 = GameObject.Find("LFoot14");
        REye15 = GameObject.Find("REye15");
        LEye16 = GameObject.Find("LEye16");
        REar17 = GameObject.Find("REar17");
        LEar18 = GameObject.Find("LEar18");
        LToe19 = GameObject.Find("LToe19");
        LSToe20 = GameObject.Find("LSToe20");
        LHeel21 = GameObject.Find("LHeel21");
        RToe22 = GameObject.Find("RToe22");
        RSToe23 = GameObject.Find("RSToe23");
        RHeel24 = GameObject.Find("RHeel24");
    }

    public static void switcherUPdate(int nummber)
    {
        switcher += nummber;
    }
    public static void actionUPdate(int nummber)
    {
        action += nummber;
    }

    public static void typeUPdate(float number)
    {
        type += number;
    }

    void Start()
    {
        InitObject();
    }
    void Update()
    {
        //動作標題
        if (StartTime.StartNumber <= 0)
        {
            switch (action)
            {
                case 0:
                    switch (type)
                    {
                        case 0:
                            PositionText.text = "背部挺直";
                            break;
                        case 1:
                            PositionText.text = "雙腳與肩同寬";
                            break;
                        case 2:
                            PositionText.text = "抬腿";
                            break;
                    }
                    break;
                case 1:
                    switch (type)
                    {
                        case 0:
                            PositionText.text = "背部挺直";
                            break;
                        case 1:
                            PositionText.text = "雙腳與肩同寬";
                            break;
                        case 2:
                            PositionText.text = "深蹲";
                            break;
                    }
                    break;
                case 2:
                    switch (type)
                    {
                        case 0:
                            PositionText.text = "背部挺直";
                            break;
                        case 1:
                            PositionText.text = "雙腳與肩同寬";
                            break;
                        case 2:
                            PositionText.text = "取得適當站距";
                            break;
                        case 3:
                            PositionText.text = "進行保加利亞蹲";
                            break;

                    }
                    break;
            }
        }
        if (action == 0 || action == 1 || action == 2)
        {

            if (type == 0 && StartTime.StartNumber <= 0)
            {

                ScoreNumText.text = score.ToString();
                ClearTimer.StartTimeCounting();
                if (Math.Abs(MMid1.transform.localPosition.x - MAss8.transform.localPosition.x) <= range &&
                    Math.Abs(MMid1.transform.localPosition.z - MAss8.transform.localPosition.z) <= range)
                {
                    ClearTimer.stop1 = false;
                    StandText.transform.localPosition = new Vector3(100, 347, 0);
                    StandText.alignment = TextAlignmentOptions.Center;
                    StandText.color = Color.green;
                    StandText.text = "正確!";
                    if (ClearTimer.takeTime >= 3)
                    {
                        switcherUPdate(-1);
                        typeUPdate(1);
                        StandText.text = "";
                        ClearTimer.stop1 = true;
                        ClearTimer.InitTime();
                    }
                }
                else
                {
                    StandText.transform.localPosition = new Vector3(-100, 347, 0);
                    StandText.color = Color.red;
                    StandText.alignment = TextAlignmentOptions.Center;
                    StandText.text = "錯誤!";
                    ClearTimer.stop1 = true;
                    ClearTimer.InitTime();
                    st_count++;
                }
            }
            if (switcher <= 7)
            {

                if (Math.Abs(MMid1.transform.localPosition.x - MAss8.transform.localPosition.x) <= onother_range &&
                Math.Abs(MMid1.transform.localPosition.z - MAss8.transform.localPosition.z) <= onother_range)
                {
                    StandText.text = "";
                }
                else
                {
                    st_count++;
                    StandText.color = Color.red;
                    StandText.transform.localPosition = new Vector3(700, -470, 0);
                    StandText.alignment = TextAlignmentOptions.Right;
                    StandText.text = "站姿未挺直!";
                }
            }
        }
    }
}