using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STAR2 : MonoBehaviour
{
    private Animator anim;
    public int TimeLimit = 3;
    private bool hasPlayedAnimation = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log("進入start");
        anim.SetBool("StarFadeOut", false);
        if (Stand.action == 0)
        {
            TimeLimit = 60;
        }

        if (Stand.action == 1)
        {
            TimeLimit = 55;
        }

        if (Stand.action == 2)
        {
            TimeLimit = 75;
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log("Time Limit: " + TimeLimit);        
        if (ClearTimer.clearTime >= TimeLimit && !hasPlayedAnimation)
        {

            // anim.SetTrigger("star");
            anim.SetBool("StarFadeOut", true);
            hasPlayedAnimation = true;
            Debug.Log("進入if");
        }
        // anim.SetBool("StarFadeOut", false);
    }

}
