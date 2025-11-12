using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MoveJoints : MonoBehaviour
{
    #region definition

    public float speed = 5f;
    //线段渲染器*4  
    private LineRenderer lineRenderer1;
    private LineRenderer lineRenderer2;
    private LineRenderer lineRenderer3;
    private LineRenderer lineRenderer4;

    private string[] line_one = new string[] { "MNose0", "MMid1", "LShoulder5", "LElbow6", "LWrist7" };
    private string[] line_two = new string[] { "MNose0", "MMid1", "RShoulder2", "RElbow3", "RWrist4" };
    private string[] line_three = new string[] { "MMid1", "MAss8", "LAss12", "LKnee13", "LFoot14", "LToe19" };
    private string[] line_four = new string[] { "MMid1", "MAss8", "RAss9", "RKnee10", "RFoot11", "RToe22" };
    private int count = 0;

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

    #endregion

    //将场景的物体关联到该脚本中
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






        //   Line1 = GameObject.Find("Line1");

        lineRenderer1 = (LineRenderer)LEar18.GetComponent("LineRenderer");
        lineRenderer2 = (LineRenderer)REar17.GetComponent("LineRenderer");
        lineRenderer3 = (LineRenderer)MAss8.GetComponent("LineRenderer");
        lineRenderer4 = (LineRenderer)MMid1.GetComponent("LineRenderer");

    }

    // Use this for initialization
    void Start()
    {
        Invoke("DelayedUpdate", 1f);

        InitObject();

        lineRenderer1.positionCount = 5;
        lineRenderer2.positionCount = 5;
        lineRenderer3.positionCount = 6;
        lineRenderer4.positionCount = 6;

    }

    // void DelayedUpdate(){
    //     for(int i=0;i<7;i++){
    //         GameObject joint = GameObject.Find(line_one[i]);
    //         if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0){
    //             lineRenderer1.SetPosition(i, joint.transform.localPosition);   
    //         }
    //     }

    //     for(int i=0;i<7;i++){
    //         GameObject joint = GameObject.Find(line_two[i]);
    //         if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0){
    //             lineRenderer2.SetPosition(i, joint.transform.localPosition);   
    //         }
    //     }

    //     for(int i=0;i<4;i++){
    //         GameObject joint = GameObject.Find(line_three[i]);
    //         if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0){
    //             lineRenderer3.SetPosition(i, joint.transform.localPosition);  
    //         }
    //         else{
    //             lineRenderer4.SetPosition(i, Vector3.zero);
    //             joint.SetActive(false);
    //         }
    //     }

    //     for(int i=0;i<4;i++){
    //         GameObject joint = GameObject.Find(line_four[i]);
    //         if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0){
    //             lineRenderer4.SetPosition(i, joint.transform.localPosition); 
    //         }
    //         else{
    //             joint = GameObject.Find(line_four[i-1]);
    //             lineRenderer4.SetPosition(i, joint.transform.localPosition);
    //         }
    //     }

    // }

    void Update()
    {

        float step = speed * Time.deltaTime;
        //move joints using interpolation method

        MNose0.transform.localPosition = new Vector3(Mathf.Lerp(MNose0.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[0], step), Mathf.Lerp(MNose0.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[0], step), Mathf.Lerp(MNose0.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[0] + 4f, step));
        MMid1.transform.localPosition = new Vector3(Mathf.Lerp(MMid1.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[1], step), Mathf.Lerp(MMid1.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[1], step), Mathf.Lerp(MMid1.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[1], step));
        RShoulder2.transform.localPosition = new Vector3(Mathf.Lerp(RShoulder2.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[2], step), Mathf.Lerp(RShoulder2.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[2], step), Mathf.Lerp(RShoulder2.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[2], step));
        RElbow3.transform.localPosition = new Vector3(Mathf.Lerp(RElbow3.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[3], step), Mathf.Lerp(RElbow3.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[3], step), Mathf.Lerp(RElbow3.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[3], step));
        RWrist4.transform.localPosition = new Vector3(Mathf.Lerp(RWrist4.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[4], step), Mathf.Lerp(RWrist4.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[4], step), Mathf.Lerp(RWrist4.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[4], step));
        LShoulder5.transform.localPosition = new Vector3(Mathf.Lerp(LShoulder5.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[5], step), Mathf.Lerp(LShoulder5.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[5], step), Mathf.Lerp(LShoulder5.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[5], step));
        LElbow6.transform.localPosition = new Vector3(Mathf.Lerp(LElbow6.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[6], step), Mathf.Lerp(LElbow6.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[6], step), Mathf.Lerp(LElbow6.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[6], step));
        LWrist7.transform.localPosition = new Vector3(Mathf.Lerp(LWrist7.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[7], step), Mathf.Lerp(LWrist7.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[7], step), Mathf.Lerp(LWrist7.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[7], step));
        MAss8.transform.localPosition = new Vector3(Mathf.Lerp(MAss8.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[8], step), Mathf.Lerp(MAss8.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[8], step), Mathf.Lerp(MAss8.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[8], step));
        RAss9.transform.localPosition = new Vector3(Mathf.Lerp(RAss9.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[9], step), Mathf.Lerp(RAss9.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[9], step), Mathf.Lerp(RAss9.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[9], step));
        RKnee10.transform.localPosition = new Vector3(Mathf.Lerp(RKnee10.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[10], step), Mathf.Lerp(RKnee10.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[10], step), Mathf.Lerp(RKnee10.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[10], step));
        RFoot11.transform.localPosition = new Vector3(Mathf.Lerp(RFoot11.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[11], step), Mathf.Lerp(RFoot11.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[11], step), Mathf.Lerp(RFoot11.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[11], step));
        LAss12.transform.localPosition = new Vector3(Mathf.Lerp(LAss12.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[12], step), Mathf.Lerp(LAss12.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[12], step), Mathf.Lerp(LAss12.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[12], step));
        LKnee13.transform.localPosition = new Vector3(Mathf.Lerp(LKnee13.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[13], step), Mathf.Lerp(LKnee13.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[13], step), Mathf.Lerp(LKnee13.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[13], step));
        LFoot14.transform.localPosition = new Vector3(Mathf.Lerp(LFoot14.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[14], step), Mathf.Lerp(LFoot14.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[14], step), Mathf.Lerp(LFoot14.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[14], step));
        REye15.transform.localPosition = new Vector3(Mathf.Lerp(REye15.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[15], step), Mathf.Lerp(REye15.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[15], step), Mathf.Lerp(REye15.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[15], step));
        LEye16.transform.localPosition = new Vector3(Mathf.Lerp(LEye16.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[16], step), Mathf.Lerp(LEye16.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[16], step), Mathf.Lerp(LEye16.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[15], step));
        REar17.transform.localPosition = new Vector3(Mathf.Lerp(REar17.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[17], step), Mathf.Lerp(REar17.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[17], step), Mathf.Lerp(REar17.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[17], step));
        LEar18.transform.localPosition = new Vector3(Mathf.Lerp(LEar18.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[18], step), Mathf.Lerp(LEar18.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[18], step), Mathf.Lerp(LEar18.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[17], step));
        LToe19.transform.localPosition = new Vector3(Mathf.Lerp(LToe19.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[19], step), Mathf.Lerp(LToe19.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[19], step), Mathf.Lerp(LToe19.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[19], step));
        LSToe20.transform.localPosition = new Vector3(Mathf.Lerp(LSToe20.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[20], step), Mathf.Lerp(LSToe20.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[20], step), Mathf.Lerp(LSToe20.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[20], step));
        LHeel21.transform.localPosition = new Vector3(Mathf.Lerp(LHeel21.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[21], step), Mathf.Lerp(LHeel21.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[21], step), Mathf.Lerp(LHeel21.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[21], step));
        RToe22.transform.localPosition = new Vector3(Mathf.Lerp(RToe22.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[22], step), Mathf.Lerp(RToe22.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[22], step), Mathf.Lerp(RToe22.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[22], step));
        RSToe23.transform.localPosition = new Vector3(Mathf.Lerp(RSToe23.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[23], step), Mathf.Lerp(RSToe23.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[23], step), Mathf.Lerp(RSToe23.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[23], step));
        RHeel24.transform.localPosition = new Vector3(Mathf.Lerp(RHeel24.transform.localPosition.x, 0.1f * JsonTest.pose_joint_x[24], step), Mathf.Lerp(RHeel24.transform.localPosition.y, -0.1f * JsonTest.pose_joint_y[24], step), Mathf.Lerp(RHeel24.transform.localPosition.z, -0.1f * JsonTest.pose_joint_z[24], step));

        //#endregion

        //将场景的物体关联到该脚本中


        for (int i = 0; i < 5; i++)
        {
            GameObject joint = GameObject.Find(line_one[i]);
            if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
            {
                lineRenderer1.SetPosition(i, joint.transform.localPosition);
            }
            while (joint.transform.localPosition.x == 0 && joint.transform.localPosition.y == 0 && joint.transform.localPosition.z == 0
                    ||
                    joint.transform.localPosition.z == 0)
            {
                if (i == 0)
                {
                    count--;
                }
                else if (i != 0)
                {
                    count++;
                }
                joint = GameObject.Find(line_one[i - count]);
                if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
                {
                    lineRenderer1.SetPosition(i, joint.transform.localPosition);
                }
            }
        }
        count = 0;

        for (int i = 0; i < 5; i++)
        {
            GameObject joint = GameObject.Find(line_two[i]);
            if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
            {
                lineRenderer2.SetPosition(i, joint.transform.localPosition);
            }
            while (joint.transform.localPosition.x == 0 && joint.transform.localPosition.y == 0 && joint.transform.localPosition.z == 0
                    ||
                    joint.transform.localPosition.z == 0)
            {
                if (i == 0)
                {
                    count--;
                }
                else if (i != 0)
                {
                    count++;
                }
                joint = GameObject.Find(line_two[i - count]);
                if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
                {
                    lineRenderer2.SetPosition(i, joint.transform.localPosition);
                }
            }
        }
        count = 0;

        for (int i = 0; i < 6; i++)
        {
            GameObject joint = GameObject.Find(line_three[i]);
            if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
            {
                lineRenderer3.SetPosition(i, joint.transform.localPosition);
            }
            while (joint.transform.localPosition.x == 0 && joint.transform.localPosition.y == 0 && joint.transform.localPosition.z == 0
                    ||
                    joint.transform.localPosition.z == 0)
            {
                if (i == 0)
                {
                    count--;
                }
                else if (i != 0)
                {
                    count++;
                }
                joint = GameObject.Find(line_three[i - count]);
                if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
                {
                    lineRenderer3.SetPosition(i, joint.transform.localPosition);
                }
            }
        }
        count = 0;

        for (int i = 0; i < 6; i++)
        {
            GameObject joint = GameObject.Find(line_four[i]);
            if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
            {
                lineRenderer4.SetPosition(i, joint.transform.localPosition);
            }
            while (joint.transform.localPosition.x == 0 && joint.transform.localPosition.y == 0 && joint.transform.localPosition.z == 0
                    ||
                    joint.transform.localPosition.z == 0)
            {
                if (i == 0)
                {
                    count--;
                }
                else if (i != 0)
                {
                    count++;
                }
                joint = GameObject.Find(line_four[i - count]);
                if (joint.transform.localPosition.x != 0 && joint.transform.localPosition.y != 0)
                {
                    lineRenderer4.SetPosition(i, joint.transform.localPosition);
                }
            }
        }
        count = 0;
    }
}
