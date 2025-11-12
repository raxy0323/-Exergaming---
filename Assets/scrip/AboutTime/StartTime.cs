using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StartTime : MonoBehaviour
{
    public static float StartNumber = 3;
    public TextMeshProUGUI startime;
    private bool isVisible = true;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (StartNumber >= 0)
        {
            StartNumber -= Time.fixedDeltaTime;
            startime.text = System.TimeSpan.FromSeconds(StartNumber).ToString(format: @"s\:ff");
            isVisible = true;
        }
        else
        {
            isVisible = false;
        }
        gameObject.SetActive(isVisible);
    }
}
