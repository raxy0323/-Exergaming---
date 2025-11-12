using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;
using UnityEngine.SceneManagement;

public class PreChangeButton : MonoBehaviour
{
    public TextMeshProUGUI SongName;
    public string[] songlist = new string[] { "#1 happy", "#2 relax", "#3 hyper" };
    private void Start()
    {
        // 查找按钮组件
        Button button = GetComponent<Button>();

        // 添加按钮点击事件处理程序
        button.onClick.AddListener(NextTrack);
    }

    private void NextTrack()
    {
        if (MusicChoose.musicnum > 1)
        {
            MusicChoose.musicnum -= 1;
        }
        else if (MusicChoose.musicnum == 1)
        {
            MusicChoose.musicnum = MusicChoose.Tracknum;
        }
        for (int i = 1; i <= MusicChoose.Tracknum; i++)
        {
            if (i == MusicChoose.musicnum)
            {
                SongName.text = songlist[i - 1];
            }
        }
    }
}
