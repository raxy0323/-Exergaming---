using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetTime : MonoBehaviour
{
    public TextMeshProUGUI gettimeText;

    void Start()
    {

    }


    void Update()
    {
        gettimeText.text = System.TimeSpan.FromSeconds(ClearTimer.clearTime).ToString(format: @"mm\:ss\:ff");
    }
}
