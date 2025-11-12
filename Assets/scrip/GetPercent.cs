using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetPercent : MonoBehaviour
{
    public TextMeshProUGUI text_1;
    public TextMeshProUGUI text_2;
    public TextMeshProUGUI text_3;
    public TextMeshProUGUI text_4;
    public TextMeshProUGUI text_5;
    private int total;
    public static int val1;
    public static int val2;
    public static int val3;
    public static int val4;
    public static int val5;
    void Update()
    {
        total = Stand.st_count + ShoulderDicide.sh_count + LegLength.le_count + KneeDecide.fo_count + KneeDecide.ba_count;
        val1 = Stand.st_count * 100 / total;
        val2 = ShoulderDicide.sh_count * 100 / total;
        val3 = LegLength.le_count * 100 / total;
        val4 = KneeDecide.fo_count * 100 / total;
        val5 = KneeDecide.ba_count * 100 / total;

        text_1.text = val1.ToString() + "%";
        text_2.text = val2.ToString() + "%";
        text_3.text = val3.ToString() + "%";
        text_4.text = val4.ToString() + "%";
        text_5.text = val5.ToString() + "%";
    }
}
