using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReStartButton : MonoBehaviour
{
    public string sceneToLoad;
    public Button SettingButton;
    public GameObject popupWindow;
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(reset);
    }
    void reset()
    {
        Stand.type = 0;
        Stand.switcher = 8;
        ClearTimer.ResetTime();
        ClearTimer.InitTime();
        
        ClearTimer.stop = true;
        ClearTimer.stop1 = true;
        // ClearTimer.stop = false;
        // ClearTimer.stop1 = false;
        popupWindow.SetActive(false);
        SettingButton.interactable = true;
        StartTime.StartNumber = 3;
        SceneManager.LoadScene(sceneToLoad);
    }

}
