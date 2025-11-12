using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitYesBtn : MonoBehaviour
{
    public void start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(QuitGame);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
