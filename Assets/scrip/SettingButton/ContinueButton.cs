using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    public Button SettingButton;
    public GameObject popupWindow;
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(GoBack);
    }
    void GoBack()
    {
        ClearTimer.stop = false;
        Stand.type = SettingView.tempType;
        popupWindow.SetActive(false);
        SettingButton.interactable = true;
    }
}
