using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMove : MonoBehaviour
{
    public float amplitude = 10f;       // 波浪振幅
    public float frequency = 1f;       // 波浪频率
    public float speed = 1f;           // 波浪速度

    private Text textComponent;
    private Vector3 startPosition;

    void Start()
    {
        // 获取Text组件和初始位置
        textComponent = GetComponent<Text>();
        startPosition = transform.localPosition;

        // 启动协程来执行波浪运动
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        float time = 0f;

        while (true)
        {
            // 计算新的Y位置
            float newY = startPosition.y + amplitude * Mathf.Sin(frequency * time);

            // 更新文本的位置
            Vector3 newPosition = new Vector3(startPosition.x, newY, startPosition.z);
            transform.localPosition = newPosition;

            // 增加时间以实现动画效果
            time += Time.deltaTime * speed;

            yield return null;
        }
    }
}
