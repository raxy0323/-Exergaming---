using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class HighLeg : MonoBehaviour
{
    public TextMeshProUGUI HighLegText;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreNumText;
    public TextMeshProUGUI type_counting;
    public string EndingScene;

    public int range = 1;
    public int reload_range = 1;
    public static int TimesToNext = 5;
    private bool ifReload = true;
    private int highlegcount = 0;


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
        //Text init
        HighLegText.enabled = false;
        HighLegText.transform.localPosition = new Vector3(-600, -250, 0);
    }

    void Start()
    {
        InitObject();
    }
    void Update()
    {

        if (Stand.action == 0 && Stand.type == 2)
        {
            MNose0.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[0], -0.1f * JsonTest.pose_joint_y[0], -0.1f * JsonTest.pose_joint_z[0] + 1.5f);
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
            RFoot11.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[11], -0.1f * JsonTest.pose_joint_y[11], -0.1f * JsonTest.pose_joint_z[11]);
            LAss12.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[12], -0.1f * JsonTest.pose_joint_y2[12], -0.1f * JsonTest.pose_joint_z[12]);
            LKnee13.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[13], -0.1f * JsonTest.pose_joint_y2[13], -0.1f * JsonTest.pose_joint_z[13]);
            LFoot14.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[14], -0.1f * JsonTest.pose_joint_y[14], -0.1f * JsonTest.pose_joint_z[14]);
            REye15.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[15], -0.1f * JsonTest.pose_joint_y[15], -0.1f * JsonTest.pose_joint_z[15]);
            LEye16.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[16], -0.1f * JsonTest.pose_joint_y[16], -0.1f * JsonTest.pose_joint_z[15]);
            REar17.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[17], -0.1f * JsonTest.pose_joint_y[17], -0.1f * JsonTest.pose_joint_z[17]);
            LEar18.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[18], -0.1f * JsonTest.pose_joint_y[18], -0.1f * JsonTest.pose_joint_z[17]);
            LToe19.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[19], -0.1f * JsonTest.pose_joint_y[19], -0.1f * JsonTest.pose_joint_z[19]);
            LSToe20.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[20], -0.1f * JsonTest.pose_joint_y[20], -0.1f * JsonTest.pose_joint_z[20]);
            LHeel21.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[21], -0.1f * JsonTest.pose_joint_y[21], -0.1f * JsonTest.pose_joint_z[21]);
            RToe22.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[22], -0.1f * JsonTest.pose_joint_y[22], -0.1f * JsonTest.pose_joint_z[22]);
            RSToe23.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[23], -0.1f * JsonTest.pose_joint_y[23], -0.1f * JsonTest.pose_joint_z[23]);
            RHeel24.transform.localPosition = new Vector3(0.1f * JsonTest.pose_joint_x[24], -0.1f * JsonTest.pose_joint_y[24], -0.1f * JsonTest.pose_joint_z[24]);



            HighLegText.enabled = true;
            HighLegText.color = Color.white;
            HighLegText.transform.localPosition = new Vector3(-690, -470, 0);
            HighLegText.alignment = TextAlignmentOptions.Left;
            HighLegText.text = "次數 :" + highlegcount;
            ClearTimer.StartTimeCounting();
            //判斷兩邊膝蓋有沒有高過屁股 
            //節點編號[9、10、12、13座標為 [x,y2,z]] 
            if (Math.Abs(RAss9.transform.localPosition.y - RKnee10.transform.localPosition.y) <= range ||
                Math.Abs(LAss12.transform.localPosition.y - LKnee13.transform.localPosition.y) <= range)
            {
                if (ifReload)
                {
                    highlegcount += 1;
                    ifReload = false;
                }

            }
            else if (Math.Abs(LKnee13.transform.localPosition.y - RKnee10.transform.localPosition.y) <= reload_range)
            {
                ifReload = true;
            }

            if (highlegcount == TimesToNext)
            {
                SceneManager.LoadScene(EndingScene);
                HighLegText.enabled = false;
            }


        }
    }
}