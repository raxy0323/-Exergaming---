using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class PreLevelChoose : MonoBehaviour
{

    public TextMeshProUGUI LevelText;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;

    void Start()
    {
        InitAnimator();
        AnimatorController();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(NextLevel);
    }

    void NextLevel()
    {
        if (Stand.action >= 1)
            Stand.action -= 1;
        else if (Stand.action == 0)
            Stand.action = 2;
        AnimatorController();
    }
    void AnimatorController()
    {
        if (Stand.action == 0)
        {
            InitAnimator();
            level1.SetActive(true);
            LevelText.text = "Level #1";
        }
        if (Stand.action == 1)
        {
            InitAnimator();
            level2.SetActive(true);
            LevelText.text = "Level #2";
        }
        if (Stand.action == 2)
        {
            InitAnimator();
            level3.SetActive(true);
            LevelText.text = "Level #3";
        }
    }
    void InitAnimator()
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
    }
}

