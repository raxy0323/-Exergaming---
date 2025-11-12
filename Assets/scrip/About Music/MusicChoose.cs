using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChoose : MonoBehaviour
{
    public static int musicnum = 1;
    public static int Tracknum = 3;
    public AudioSource Tracks1;
    public AudioSource Tracks2;
    public AudioSource Tracks3;

    // Start is called before the first frame update
    void Start()
    {
        InitMusic(); // 將 MusicChoose 的實例傳遞給 InitMusic
    }

    public void InitMusic()
    {
        Tracks1.enabled = false;
        Tracks2.enabled = false;
        Tracks3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (musicnum == 1)
        {
            Tracks1.enabled = true;
            Tracks2.enabled = false;
            Tracks3.enabled = false;
        }
        if (musicnum == 2)
        {
            Tracks1.enabled = false;
            Tracks2.enabled = true;
            Tracks3.enabled = false;
        }
        if (musicnum == 3)
        {
            Tracks1.enabled = false;
            Tracks2.enabled = false;
            Tracks3.enabled = true;
        }
    }
}
