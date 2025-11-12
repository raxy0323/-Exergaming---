using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class KneeDecide : MonoBehaviour
{
    public TextMeshProUGUI FrontKneeText;
    public TextMeshProUGUI BackKneeText;
    public TextMeshProUGUI CountingText;
    public TextMeshProUGUI ScoreNumText;
    public TextMeshProUGUI type_counting;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI switcherText;
    public float updateInterval = 1f;
    public static int frontknee_range = 2;
    public int backknee_range = 3;
    public int reload_range = 2;
    public int other_range4 = 10;
    public int squat_range = 5;
    public static int bscount = 0;
    public static bool ifReload = true;
    public string ChangeGap;
    public string EndingScene;
    public static int fo_count = 0;
    public static int ba_count = 0;


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
            if (Stand.type == 3)
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
                RAss9.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[9], -0.1f * JsonTest.pose_joint_y2[9], -0.1f * JsonTest.pose_joint_z[9]);
                RKnee10.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[10], -0.1f * JsonTest.pose_joint_y2[10], -0.1f * JsonTest.pose_joint_z[10]);
                RFoot11.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[11], -0.1f * JsonTest.pose_joint_y2[11], -0.1f * JsonTest.pose_joint_z[11]);
                LAss12.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[12], -0.1f * JsonTest.pose_joint_y2[12], -0.1f * JsonTest.pose_joint_z[12]);
                LKnee13.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[13], -0.1f * JsonTest.pose_joint_y2[13], -0.1f * JsonTest.pose_joint_z[13]);
                LFoot14.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[14], -0.1f * JsonTest.pose_joint_y2[14], -0.1f * JsonTest.pose_joint_z[14]);
                REye15.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[15], -0.1f * JsonTest.pose_joint_y[15], -0.1f * JsonTest.pose_joint_z[15]);
                LEye16.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[16], -0.1f * JsonTest.pose_joint_y[16], -0.1f * JsonTest.pose_joint_z[16]);
                REar17.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[17], -0.1f * JsonTest.pose_joint_y[17], -0.1f * JsonTest.pose_joint_z[17]);
                LEar18.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[18], -0.1f * JsonTest.pose_joint_y[18], -0.1f * JsonTest.pose_joint_z[18]);
                LToe19.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[19], -0.1f * JsonTest.pose_joint_y[19], -0.1f * JsonTest.pose_joint_z[19]);
                LSToe20.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[20], -0.1f * JsonTest.pose_joint_y[20], -0.1f * JsonTest.pose_joint_z[20]);
                LHeel21.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[21], -0.1f * JsonTest.pose_joint_y[21], -0.1f * JsonTest.pose_joint_z[21]);
                RToe22.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[22], -0.1f * JsonTest.pose_joint_y[22], -0.1f * JsonTest.pose_joint_z[22]);
                RSToe23.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[23], -0.1f * JsonTest.pose_joint_y[23], -0.1f * JsonTest.pose_joint_z[23]);
                RHeel24.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[24], -0.1f * JsonTest.pose_joint_y[24], -0.1f * JsonTest.pose_joint_z[24]);
                //節點編號9、10、11、12、13、14座標為 [x,y2,z]]

                CountingText.color = Color.white;
                CountingText.transform.localPosition = new Vector3(-690, -470, 0);
                CountingText.text = "次數: " + bscount.ToString();
                ScoreNumText.text = Stand.score.ToString();
                ClearTimer.StartTimeCounting();
                //進入偵測
                if (Math.Abs(LKnee13.transform.localPosition.z - LToe19.transform.localPosition.z) < frontknee_range
                    && Math.Abs(RKnee10.transform.localPosition.y - LFoot14.transform.localPosition.y) <= backknee_range)
                {
                    //次數增加並確保不會重複計數
                    if (ifReload)
                    {
                        bscount += 1;
                        ifReload = false;
                    }
                }
                else if (Math.Abs(LKnee13.transform.localPosition.z - LAss12.transform.localPosition.z) <= reload_range)
                {
                    ifReload = true;
                }
                //判斷是否下蹲來決定是否給出錯誤訊息
                if (LAss12.transform.localPosition.y - LKnee13.transform.localPosition.y < squat_range)
                {

                    if (Math.Abs(LKnee13.transform.localPosition.z - LToe19.transform.localPosition.z) < frontknee_range)
                    {
                        FrontKneeText.transform.localPosition = new Vector3(-150, 230, 0);
                        FrontKneeText.color = Color.red;
                        FrontKneeText.text = "前腳錯誤!";
                        fo_count++;

                    }
                    if (Math.Abs(RKnee10.transform.localPosition.y - LFoot14.transform.localPosition.y) <= backknee_range)
                    {
                        BackKneeText.transform.localPosition = new Vector3(150, 230, 0);
                        BackKneeText.color = Color.red;
                        BackKneeText.text = "後腳錯誤!";
                        ba_count++;
                    }
                }
                else if (ifReload)
                {
                    FrontKneeText.transform.localPosition = new Vector3(0, 40, 0);
                    FrontKneeText.color = Color.green;
                    FrontKneeText.text = "";
                    BackKneeText.text = "";
                }




                if (ifReload == false)
                {
                    FrontKneeText.transform.localPosition = new Vector3(0, 40, 0);
                    FrontKneeText.color = Color.green;
                    FrontKneeText.text = "前腳站直重置辨識";
                    BackKneeText.text = "";
                }


                if (bscount == 3)
                {
                    Stand.switcherUPdate(-4);
                    bscount = 0;
                    Stand.typeUPdate(4);
                    ClearTimer.stop = true;
                    StartTime.StartNumber = 3;
                    SceneManager.LoadScene(ChangeGap);
                }
            }

            /*
            if (Stand.type == 5 && StartTime.StartNumber <= 0)
            {
                CountingText.color = Color.white;
                CoutingText.transform.localPosition = new Vector3(-690, -470, 0);
                CountingText.text = "次數: " + bscount.ToString();
                ScoreNumText.text = Stand.score.ToString();
                ClearTimer.StartTimeCounting();

                if (Math.Abs(RKnee10.transform.localPosition.z - RToe22.transform.localPosition.z) < frontknee_range
                    && Math.Abs(LKnee13.transform.localPosition.y - RFoot11.transform.localPosition.y) <= backknee_range)
                {
                    //次數增加並確保不會重複計數
                    if (ifReload)
                    {
                        bscount += 1;
                        ifReload = false;
                    }
                }
                else if (Math.Abs(RKnee10.transform.localPosition.z - RAss9.transform.localPosition.z) <= reload_range)
                {
                    ifReload = true;
                }
                //判斷是否下蹲來決定是否給出錯誤訊息
                if (RAss9.transform.localPosition.y - RKnee10.transform.localPosition.y < squat_range)
                {

                    if (Math.Abs(RKnee10.transform.localPosition.z - RToe22.transform.localPosition.z) < frontknee_range)
                    {   
                        FrontKneeTex
                        FrontKneeText.color = Color.red;
                        FrontKneeText.text = "前腳錯誤!";
                        fo_count++;
                    }
                    if (Math.Abs(LKnee13.transform.localPosition.y - RFoot11.transform.localPosition.y) <= backknee_range)
                    {
                        BackKneeText.color = Color.red;
                        BackKneeText.text = "後腳錯誤!";
                        ba_count++;
                    }
                }
                else if (ifReload)
                {
                    FrontKneeText.color = Color.green;
                    FrontKneeText.text = "請進行下一個深蹲";
                    BackKneeText.text = "";
                }




                if (ifReload == false)
                {
                    FrontKneeText.color = Color.green;
                    FrontKneeText.text = "前腳站直重置辨識";
                    BackKneeText.text = "";
                }


                if (bscount == 5)
                {
                    Stand.switcherUPdate(-2);
                    bscount = 0;
                    Stand.typeUPdate(2);
                    ClearTimer.stop = true;
                    StartTime.StartNumber = 3;
                    SceneManager.LoadScene(EndingScene);
                }
            }
        */
        }

    }
}