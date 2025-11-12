using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstViewCamera : MonoBehaviour
{
    public float rotationSpeed = 30.0f;  // 旋转速度
    public float rotationAngle = 45.0f;  // 旋转角度
    public float rotationDuration = 2.0f;  // 旋转一次的时间

    private Quaternion startRotation;
    private Quaternion endRotation;
    private float startTime;

    void Start()
    {
        startRotation = transform.rotation;
        endRotation = Quaternion.Euler(0, rotationAngle, 0) * startRotation; // 计算目标旋转
        startTime = Time.time;
    }

    void Update()
    {
        // 计算当前的时间进度（0到1之间）
        float t = (Time.time - startTime) / rotationDuration;

        // 使用插值函数来平滑旋转摄像机
        transform.rotation = Quaternion.Lerp(startRotation, endRotation, Mathf.PingPong(t, 1));

        // 如果到达终点位置，交换起始和终点位置以反向移动
        if (t >= 1.0f)
        {
            Quaternion temp = startRotation;
            startRotation = endRotation;
            endRotation = temp;
            startTime = Time.time;
        }
    }
}
