using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ArrowControl : MonoBehaviour
{
    // public static Transform RFoot9;
    public static GameObject MNose0;
    public static GameObject MMid1;
    public static GameObject RShoulder2;
    public static GameObject RElbow3;
    public static GameObject RWrist4;
    public static GameObject LShoulder5;
    public static GameObject LElbow6;
    public static GameObject LWrist7;
    public static GameObject MAss8;
    public static GameObject RAss9;
    public static GameObject RKnee10;
    public static GameObject RFoot11;
    public static GameObject LAss12;
    public static GameObject LKnee13;
    public static GameObject LFoot14;
    public static GameObject REye15;
    public static GameObject LEye16;
    public static GameObject REar17;
    public static GameObject LEar18;
    public static GameObject LToe19;
    public static GameObject LSToe20;
    public static GameObject LHeel21;
    public static GameObject RToe22;
    public static GameObject RSToe23;
    public static GameObject RHeel24;
    public static GameObject Arrow_up;
    public static GameObject Arrow_down;
    public static GameObject Arrow_left;
    public static GameObject Arrow_right;
    public static int LLrange = 8;
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
        Arrow_up = GameObject.Find("arrow_up");
        Arrow_down = GameObject.Find("arrow_down");
        Arrow_left = GameObject.Find("arrow_left");
        Arrow_right = GameObject.Find("arrow_right");

    }
    void Start()
    {
        InitObject();
        InitArrow();
        Arrow_up.transform.localEulerAngles = new Vector3(0, 90, 0);
        Arrow_down.transform.localEulerAngles = new Vector3(0, 90, 0);
        Arrow_right.transform.localEulerAngles = new Vector3(0, 90, 0);
        Arrow_left.transform.localEulerAngles = new Vector3(0, 90, 0);
    }
    //改方向 。 
    // Update is called once per frame
    public static void InitArrow()
    {
        Arrow_up.transform.localPosition = new Vector3(10000, 0, 0);
        Arrow_down.transform.localPosition = new Vector3(10000, 0, 0);
        Arrow_left.transform.localPosition = new Vector3(10000, 0, 0);
        Arrow_right.transform.localPosition = new Vector3(10000, 0, 0);
    }
    void Update()
    {
        Arrow();

    }
    public static void Arrow()
    {
        float t = Mathf.PingPong(Time.time * 2f, 1.0f);

        if (Stand.type == 2 && Stand.action == 2)
        {
            if (LegLength.ans - LegLength.length > LegLength.range3 + 2)
            {
                Arrow_left.transform.localPosition = new Vector3(10000, 0, 0);
                Arrow_right.transform.localPosition = new Vector3(
                    RFoot11.transform.localPosition.x,
                    RFoot11.transform.localPosition.y,
                    Mathf.Lerp(RFoot11.transform.localPosition.z - 5, RFoot11.transform.localPosition.z - 20, t)
                    + 5);
            }

            else if (LegLength.ans - LegLength.length < (LegLength.range3 + 2) * -1)
            {
                Arrow_right.transform.localPosition = new Vector3(10000, 0, 0);
                Arrow_left.transform.localPosition = new Vector3(
                    RFoot11.transform.localPosition.x,
                    RFoot11.transform.localPosition.y,
                    Mathf.Lerp(RFoot11.transform.localPosition.z - 20, RFoot11.transform.localPosition.z - 5, t)
                    - 5);
            }
            else
            {
                InitArrow();
            }



        }



        if (Stand.type == 3 && Stand.action == 2)
        {
            if (KneeDecide.ifReload == true && Math.Abs(JsonTest.pose_joint_y2[9] - JsonTest.pose_joint_y2[10]) > 8)
            {
                if (LKnee13.transform.localPosition.z - LToe19.transform.localPosition.z > KneeDecide.frontknee_range)
                {
                    //Arrow_up.transform.localEulerAngles = new Vector3(0, 90, 90);
                    Arrow_left.transform.localPosition = new Vector3(
                        LFoot14.transform.localPosition.x,
                        RKnee10.transform.localPosition.y,
                        Mathf.Lerp(LFoot14.transform.localPosition.z - 5, LFoot14.transform.localPosition.z - 20, t) - 2
                        );
                }
                else
                {
                    InitArrow();
                }
            }
            else
            {
                InitArrow();
            }
        }
        if (Stand.type == 5 && Stand.action == 2)
        {
            if (KneeDecide.ifReload == true && Math.Abs(JsonTest.pose_joint_y2[9] - JsonTest.pose_joint_y2[10]) > 8)
            {
                if (LKnee13.transform.localPosition.z - LToe19.transform.localPosition.z > KneeDecide.frontknee_range)
                {
                    //Arrow_up.transform.localEulerAngles = new Vector3(0, 90, 90);
                    Arrow_right.transform.localPosition = new Vector3(
                        RFoot11.transform.localPosition.x,
                        LKnee13.transform.localPosition.y,
                        Mathf.Lerp(RFoot11.transform.localPosition.z - 5, RFoot11.transform.localPosition.z - 20, t) - 2
                        );
                }
                else
                {
                    InitArrow();
                }
            }
            else
            {
                InitArrow();
            }
        }
    }
}
