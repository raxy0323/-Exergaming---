using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteButton : MonoBehaviour
{
    public Sprite newSprite;
    public Sprite original;
    private Image imageToChange;

    private void Start()
    {
        imageToChange = GetComponent<Image>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(MuteOrNot);
        imageToChange.sprite = original;
    }
    void MuteOrNot()
    {
        AudioListener audioListener = Camera.main.GetComponent<AudioListener>();
        audioListener.enabled = !audioListener.enabled;
        if (audioListener.enabled == true)
        {
            imageToChange.sprite = original;
        }
        else if (audioListener.enabled == false)
        {
            imageToChange.sprite = newSprite;
        }
    }
}
