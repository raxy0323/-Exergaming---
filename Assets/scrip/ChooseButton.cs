using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseButton : MonoBehaviour
{
    public string sceneToLoad1; // 指定要加载的场景名称
    public string sceneToLoad2;
    public string sceneToLoad3;
    void Start()
    {
        // 查找按钮组件
        Button button = GetComponent<Button>();

        // 添加按钮点击事件处理程序
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        if (Stand.action == 0)
            SceneManager.LoadScene(sceneToLoad1);
        else if (Stand.action == 1)
            SceneManager.LoadScene(sceneToLoad2);
        else if (Stand.action == 2)
            SceneManager.LoadScene(sceneToLoad3);
    }
}