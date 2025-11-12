using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingView : MonoBehaviour
{
    public GameObject popupWindow;
    public static float tempType;

    // 在按钮点击时调用此方法
    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ShowPopupAndStopTimer);
    }

    public void ShowPopupAndStopTimer()
    {
        popupWindow.SetActive(true);
        ClearTimer.stop = true;
        ClearTimer.stop1 = true;
        tempType = Stand.type;
        Stand.type = 100;
        Button button = GetComponent<Button>();
        button.interactable = false;
    }
}
