using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class ShoulderDicide : MonoBehaviour
{
    public TextMeshProUGUI ShoulderText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreNumText;
    public TextMeshProUGUI type_counting;
    public float updateInterval = 1f;
    public int range2 = 3;
    public int onother_range2 = 5;
    public static int sh_count = 0;
    // public int type = 0;
    // public int switcher = 0;
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


    void Start()
    {
        InitObject();
    }
    void Update()
    {
        if (Stand.action == 0 || Stand.action == 1 || Stand.action == 2)
        {
            if (Stand.type == 1)
            {
                ScoreNumText.text = Stand.score.ToString();
                ClearTimer.StartTimeCounting();
                //判斷兩脚距離是否與肩同寬
                if (Math.Abs(LShoulder5.transform.localPosition.x - LFoot14.transform.localPosition.x) <= range2 &&
                Math.Abs(RShoulder2.transform.localPosition.x - RFoot11.transform.localPosition.x) <= range2)
                {
                    ClearTimer.stop1 = false;
                    ShoulderText.transform.localPosition = new Vector3(100, 347, 0);
                    ShoulderText.alignment = TextAlignmentOptions.Center;
                    ShoulderText.color = Color.green;
                    ShoulderText.text = "正確!";
                    if (ClearTimer.takeTime >= 3)
                    {
                        ClearTimer.stop1 = true;
                        ShoulderText.text = "";
                        ClearTimer.InitTime();
                        // Stand.type += 1;
                        // Stand.switcher += -1;
                        Stand.typeUPdate(1);
                        Stand.switcherUPdate(-1);
                        ShoulderText.transform.localPosition = new Vector3(200, -150, 0);

                    }
                }
                else
                {
                    ShoulderText.transform.localPosition = new Vector3(-100, 347, 0);
                    ShoulderText.color = Color.red;
                    ShoulderText.alignment = TextAlignmentOptions.Center;
                    ShoulderText.text = "錯誤!";
                    ClearTimer.stop1 = true;
                    ClearTimer.InitTime();
                    sh_count++;
                }
            }
            if (Stand.switcher <= 6 && Stand.action == 2)
            {
                if (Math.Abs(LShoulder5.transform.localPosition.x - LFoot14.transform.localPosition.x) <= onother_range2 &&
                Math.Abs(RShoulder2.transform.localPosition.x - RFoot11.transform.localPosition.x) <= onother_range2)
                {
                    ShoulderText.text = " ";
                }
                else
                {
                    ShoulderText.alignment = TextAlignmentOptions.Right;
                    ShoulderText.color = Color.red;
                    ShoulderText.text = "未與肩同寬!";
                    ShoulderText.transform.localPosition = new Vector3(700, -380, 0);
                    sh_count++;
                }
            }
        }
    }
}