using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAnima : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    private float duration = 1.5f; // 持續時間

    void Update()
    {
        float elapsedTime = Time.time; // 已過時間
        float t = Mathf.Clamp01(elapsedTime / duration); // 使 t 在 0 到 1 之間

        get_y(image1, GetPercent.val1, t);
        get_y(image2, GetPercent.val2, t);
        get_y(image3, GetPercent.val3, t);
        get_y(image4, GetPercent.val4, t);
        get_y(image5, GetPercent.val5, t);
    }

    void get_y(Image image, int value, float t)
    {
        float startY = 0.0f; // 起始 y scale
        float endY = (4.7f * value) / 100f; // 結束 y scale
        float scaleY = Mathf.Lerp(startY, endY, Mathf.Pow(t, 1.5f)); // 使用 Mathf.Lerp 達到指數遞增或遞減
        image.transform.localScale = new Vector3(image.transform.localScale.x, scaleY, image.transform.localScale.z);
    }

}
