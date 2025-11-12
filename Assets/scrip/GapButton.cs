using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GapButton : MonoBehaviour
{
    public string sceneToLoad; // 指定要加载的场景名称

    private void Start()
    {
        // 查找按钮组件
        Button button = GetComponent<Button>();

        // 添加按钮点击事件处理程序
        button.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        // 加载指定的场景
        SceneManager.LoadScene(sceneToLoad);


    }
}
