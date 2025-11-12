using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera LegLengthCamera;
    public Camera FrontKneeCamera;
    public Camera BackKneeCamera;

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
    // Start is called before the first frame update
    void Start()
    {
        InitObject();
    }

    void initCamera()
    {
        LegLengthCamera.enabled = false;
        FrontKneeCamera.enabled = false;
        BackKneeCamera.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Stand.action == 2)
        {
            if (Stand.type == 2)
            {
                initCamera();
                LegLengthCamera.enabled = true;
                LegLengthCamera.transform.localEulerAngles = new Vector3(0, -90, 0); //更改旋轉值
                LegLengthCamera.transform.localPosition = new Vector3(
                    RKnee10.transform.localPosition.x + 40,
                    RKnee10.transform.localPosition.y,
                    RKnee10.transform.localPosition.z
                    );

            }


            if (Stand.type == 3)
            {
                initCamera();
                FrontKneeCamera.enabled = true;
                FrontKneeCamera.transform.localEulerAngles = new Vector3(0, -90, 0);
                FrontKneeCamera.transform.localPosition = new Vector3(
                    LFoot14.transform.localPosition.x + 30,
                    LFoot14.transform.localPosition.y + 5,
                    LFoot14.transform.localPosition.z + 5
                    );
            }
            if (Stand.type == 5)
            {
                initCamera();
                FrontKneeCamera.enabled = true;
                FrontKneeCamera.transform.localEulerAngles = new Vector3(0, -90, 0);
                FrontKneeCamera.transform.localPosition = new Vector3(
                    RFoot11.transform.localPosition.x + 30,
                    RFoot11.transform.localPosition.y + 5,
                    RFoot11.transform.localPosition.z + 5
                    );
            }

            if (Stand.type == 7)
            {
                initCamera();
            }
        }
    }
}
