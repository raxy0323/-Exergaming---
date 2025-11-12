using System.Collections.Generic;
using UnityEngine;

public class AudioVisualization2D : MonoBehaviour
{
    float[] _samples = new float[256]; // 增加了数组长度
    List<GameObject> _uiList = new List<GameObject>();
    public RectTransform _uiParentRect;

    public Material visualMaterial; // 新增材质
    public float lerpingSpeed = 2f; // 新增平滑下降速度

    private float[] _currentHeights; // 用于存储当前UI元素高度

    void Start()
    {
        // 获取全部UI
        for (int i = 0; i < _uiParentRect.childCount; i++)
        {
            GameObject uiObject = _uiParentRect.GetChild(i).gameObject;
            _uiList.Add(uiObject);
        }

        // 初始化_currentHeights数组
        _currentHeights = new float[_uiList.Count];
        for (int i = 0; i < _currentHeights.Length; i++)
        {
            _currentHeights[i] = _uiList[i].transform.localScale.y;
        }
    }

    void FixedUpdate()
    {
        // 获取频谱
        AudioListener.GetSpectrumData(_samples, 0, FFTWindow.BlackmanHarris);

        for (int i = 0; i < _uiList.Count; i++)
        {
            // 计算振幅，并乘以缩放因子以增强可视化效果
            float amplitude = _samples[i] * (50 + i * i * 0.5f) * 10;
            amplitude = Mathf.Clamp(amplitude, 0, 100);

            // 使用Lerp逐渐改变UI元素的高度
            _currentHeights[i] = Mathf.Lerp(_currentHeights[i], amplitude, Time.deltaTime * lerpingSpeed);

            // 设置UI元素的高度
            Vector3 scale = _uiList[i].transform.localScale;
            scale.y = _currentHeights[i];
            _uiList[i].transform.localScale = scale;

            // 设置UI元素的颜色，根据振幅的大小映射到不同的颜色
            Color color = Color.Lerp(Color.blue, Color.red, amplitude / 100f);
            visualMaterial.color = color;
        }
    }
}
