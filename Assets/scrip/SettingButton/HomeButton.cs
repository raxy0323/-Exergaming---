using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public string sceneToLoad;
    public Button SettingButton;
    public GameObject popupWindow;
    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(GoHome);
    }
    // Update is called once per frame
    private void GoHome()
    {
        Stand.type = 0;
        Stand.switcher = 8;
        ClearTimer.stop = true;
        ClearTimer.stop1 = true;
        ClearTimer.InitTime();
        ClearTimer.ResetTime();
        StartTime.StartNumber = 3;
        SceneManager.LoadScene(sceneToLoad);
        popupWindow.SetActive(false);
        SettingButton.interactable = true;
    }
}
