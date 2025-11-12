using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitNoBtn : MonoBehaviour
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
        popupWindow.SetActive(false);
        SettingButton.interactable = true;
    }
}
