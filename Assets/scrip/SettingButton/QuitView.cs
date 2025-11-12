using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitView : MonoBehaviour
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
        Button button = GetComponent<Button>();
        button.interactable = false;
    }
}
