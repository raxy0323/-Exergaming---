using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class LegLength : MonoBehaviour
{
    public TextMeshProUGUI LegText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI type_counting;
    public TextMeshProUGUI ScoreNumText;
    public static int range3 = 4;
    public int onother_range3 = 6;
    public static float ans;
    public static float length;
    public static int le_count = 0;


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
        if (Stand.action == 2)
        {
            if (Stand.type == 2)
            {
                MNose0.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[0], -0.1f * JsonTest.pose_joint_y[0], -0.1f * JsonTest.pose_joint_z[0] - 1);
                MMid1.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[1], -0.1f * JsonTest.pose_joint_y[1], -0.1f * JsonTest.pose_joint_z[1]);
                RShoulder2.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[2], -0.1f * JsonTest.pose_joint_y[2], -0.1f * JsonTest.pose_joint_z[2]);
                RElbow3.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[3], -0.1f * JsonTest.pose_joint_y[3], -0.1f * JsonTest.pose_joint_z[3]);
                RWrist4.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[4], -0.1f * JsonTest.pose_joint_y[4], -0.1f * JsonTest.pose_joint_z[4]);
                LShoulder5.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[5], -0.1f * JsonTest.pose_joint_y[5], -0.1f * JsonTest.pose_joint_z[5]);
                LElbow6.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[6], -0.1f * JsonTest.pose_joint_y[6], -0.1f * JsonTest.pose_joint_z[6]);
                LWrist7.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[7], -0.1f * JsonTest.pose_joint_y[7], -0.1f * JsonTest.pose_joint_z[7]);
                MAss8.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[8], -0.1f * JsonTest.pose_joint_y[8], -0.1f * JsonTest.pose_joint_z[8]);
                RAss9.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[9], -0.1f * JsonTest.pose_joint_y[9], -0.1f * JsonTest.pose_joint_z[9]);
                RKnee10.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[10], -0.1f * JsonTest.pose_joint_y[10], -0.1f * JsonTest.pose_joint_z[10]);
                RFoot11.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[11], -0.1f * JsonTest.pose_joint_y[11], -0.1f * JsonTest.pose_joint_z[11]);
                LAss12.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[12], -0.1f * JsonTest.pose_joint_y[12], -0.1f * JsonTest.pose_joint_z[12]);
                LKnee13.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[13], -0.1f * JsonTest.pose_joint_y2[13], -0.1f * JsonTest.pose_joint_z[13]);
                LFoot14.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[14], -0.1f * JsonTest.pose_joint_y2[14], -0.1f * JsonTest.pose_joint_z[14]);
                REye15.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[15], -0.1f * JsonTest.pose_joint_y[15], -0.1f * JsonTest.pose_joint_z[15]);
                LEye16.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[16], -0.1f * JsonTest.pose_joint_y[16], -0.1f * JsonTest.pose_joint_z[15]);
                REar17.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[17], -0.1f * JsonTest.pose_joint_y[17], -0.1f * JsonTest.pose_joint_z[17]);
                LEar18.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[18], -0.1f * JsonTest.pose_joint_y[18], -0.1f * JsonTest.pose_joint_z[17]);
                LToe19.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[19], -0.1f * JsonTest.pose_joint_y[19], -0.1f * JsonTest.pose_joint_z[19]);
                LSToe20.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[20], -0.1f * JsonTest.pose_joint_y[20], -0.1f * JsonTest.pose_joint_z[20]);
                LHeel21.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[21], -0.1f * JsonTest.pose_joint_y[21], -0.1f * JsonTest.pose_joint_z[21]);
                RToe22.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[22], -0.1f * JsonTest.pose_joint_y2[22], -0.1f * JsonTest.pose_joint_z[22]);
                RSToe23.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[23], -0.1f * JsonTest.pose_joint_y[23], -0.1f * JsonTest.pose_joint_z[23]);
                RHeel24.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[24], -0.1f * JsonTest.pose_joint_y[24], -0.1f * JsonTest.pose_joint_z[24]);


                Vector3 pointA = LAss12.transform.localPosition;
                Vector3 pointB = LKnee13.transform.localPosition;
                Vector3 pointC = LFoot14.transform.localPosition;

                Vector3 pointD = RToe22.transform.localPosition;

                float leg1 = Vector3.Distance(pointA, pointB);
                float leg2 = Vector3.Distance(pointB, pointC);
                ans = leg1 + leg2;

                length = Vector3.Distance(pointC, pointD);


                ScoreNumText.text = Stand.score.ToString();
                ClearTimer.StartTimeCounting();
                if (Math.Abs(ans - length) <= range3)
                {
                    ClearTimer.stop1 = false;
                    LegText.transform.localPosition = new Vector3(100, 347, 0);
                    LegText.color = Color.green;
                    LegText.text = "正確!";
                    if (ClearTimer.takeTime >= 3)
                    {
                        ClearTimer.stop1 = true;
                        ClearTimer.InitTime();
                        Stand.switcherUPdate(-1);
                        Stand.typeUPdate(1);
                        LegText.transform.localPosition = new Vector3(200, -150, 0);
                    }


                }
                else
                {
                    LegText.transform.localPosition = new Vector3(-100, 347, 0);
                    LegText.color = Color.red;
                    LegText.text = "錯誤!";
                    ClearTimer.stop1 = true;
                    ClearTimer.InitTime();
                    le_count++;
                }

            }
            if (Stand.switcher <= 5)
            {
                if (Math.Abs(ans - length) <= onother_range3)
                {
                    LegText.text = " ";
                }
                else
                {
                    LegText.color = Color.red;
                    LegText.alignment = TextAlignmentOptions.Right;
                    LegText.transform.localPosition = new Vector3(700, -290, 0);
                    LegText.text = "站距錯誤!";
                    le_count++;
                }
            }
        }
    }
}