using UnityEngine;
using System.IO;
using System.Text;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class JsonTest : MonoBehaviour
{
    static public float[] pose_joint_x = new float[27];
    static public float[] pose_joint_y = new float[27];
    static public float[] pose_joint_z = new float[27];
    static public float[] pose_joint_y2 = new float[27];

    int num = 0;

    // Use this for initialization 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        try
        {
            num += 1;

            if (num == 100)
            {
                num = 0;
            }


            //get the last file name 
            string numString = Convert.ToString(num);
            string pathBefore = "/Resources/OpenPose/";

            Debug.Log(pathBefore + numString + "_keypoints.json");

            //analysis data from json 
            string jsonTest = File.ReadAllText("C:/Users/User/Desktop/OPJson/" + numString + "_keypoints.json", Encoding.UTF8);
            ModelTest obj = JsonUtility.FromJson<ModelTest>(jsonTest);

            //pervent joints return to (0,0,0) 
            int arrayLength = obj.people[0].pose_keypoints_2d.Length;
            for (int i = 0; i < 25 && 4 * i + 2 < arrayLength; i++)
            {
                print("第" + i + "个点的x坐标= " + obj.people[0].pose_keypoints_2d[4 * i]);
                print("第" + i + "个点的y坐标= " + obj.people[0].pose_keypoints_2d[4 * i + 1]);
                print("側面cam的第" + i + "个点的y坐标= " + obj.people[0].pose_keypoints_2d[4 * i + 3]);
                print("第" + i + "个点的z坐标= " + obj.people[0].pose_keypoints_2d[4 * i + 2]);

                if (obj.people[0].pose_keypoints_2d[4 * i] == 0.0f)
                {
                    pose_joint_x[i] = 0.0f;
                }
                else
                {
                    pose_joint_x[i] = obj.people[0].pose_keypoints_2d[4 * i];
                }

                if (obj.people[0].pose_keypoints_2d[4 * i + 1] == 0.0f)
                {
                    pose_joint_y[i] = 0.0f;
                }
                else
                {
                    pose_joint_y[i] = obj.people[0].pose_keypoints_2d[4 * i + 1];
                }
                if (obj.people[0].pose_keypoints_2d[4 * i + 2] == 0.0f)
                {
                    pose_joint_z[i] = 0.0f;
                }
                else
                {
                    pose_joint_z[i] = obj.people[0].pose_keypoints_2d[4 * i + 2];
                }
                if (obj.people[0].pose_keypoints_2d[4 * i + 3] == 0.0f)
                {
                    pose_joint_y2[i] = 0.0f;
                }
                else
                {
                    pose_joint_y2[i] = obj.people[0].pose_keypoints_2d[4 * i + 3];
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {

        }

        //stay if file doesn't reach the num 
        catch (FileNotFoundException)
        {
            num = num - 1;
        }
        catch (IOException ex)
        {
            num = num - 1;
        }
    }
}