using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InsightBtn : MonoBehaviour
{
    public string sceneToLoad1;
    // public string sceneToLoad2;
    // public string sceneToLoad3;

    void Start()
    {
        Button InsightBtn = GetComponent<Button>();
        InsightBtn.onClick.AddListener(LoadScene);
        if (ClearTimer.clearTime < 60)
        {
            sceneToLoad1 = "InsightScene_3";
        }
        else if (ClearTimer.clearTime >= 60 && ClearTimer.clearTime < 75)
        {
            sceneToLoad1 = "InsightScene_2";
        }
        else if (ClearTimer.clearTime >= 75)
        {
            sceneToLoad1 = "InsightScene";
        }
    }


    void LoadScene()
    {

        SceneManager.LoadScene(sceneToLoad1);
    }
}
