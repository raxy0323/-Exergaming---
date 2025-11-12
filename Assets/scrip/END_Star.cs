using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END_Star : MonoBehaviour
{
    GameObject group1;
    GameObject group2;
    GameObject group3;

    public int grade1 = 0;
    public int grade2 = 0;
    public int grade3 = 0;
    void InitObject()
    {
        group1 = GameObject.Find("3point");//三星
        group2 = GameObject.Find("2point");//二星
        group3 = GameObject.Find("1point");//一星 你這裏寫反了 害我想超久
    }

    void Start()
    {
        InitObject();
    }


    void Update()
    {
        if (ClearTimer.clearTime <= grade1) //三星條件
        {
            group1.transform.localPosition = new Vector3(0, 0, 0);
            group2.transform.localPosition = new Vector3(1110, 1110, 1110);
            group3.transform.localPosition = new Vector3(1110, 1110, 1110);
        }

        if (ClearTimer.clearTime > grade1 && ClearTimer.clearTime <= grade2)//二星條件
        {
            group1.transform.localPosition = new Vector3(1110, 1110, 1110);
            group2.transform.localPosition = new Vector3(0, 0, 0);
            group3.transform.localPosition = new Vector3(1110, 1110, 1110);
        }

        if (ClearTimer.clearTime > grade2 && ClearTimer.clearTime <= grade3)//一星條件
        {
            group1.transform.localPosition = new Vector3(1110, 1110, 1110);
            group2.transform.localPosition = new Vector3(1110, 1110, 1110);
            group3.transform.localPosition = new Vector3(0, 0, 0);
        }
        if (ClearTimer.clearTime > grade3)//無星
        {
            group1.transform.localPosition = new Vector3(1110, 1110, 1110);
            group2.transform.localPosition = new Vector3(1110, 1110, 1110);
            group3.transform.localPosition = new Vector3(1110, 1110, 1110);
        }
    }
}
