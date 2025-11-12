using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioVisualizer : MonoBehaviour
{

    public AudioClip clip;
    public RectTransform imagePrefab = null;

    public FFTWindow windowType = FFTWindow.Rectangular;

    [Space(10)]
    public Transform labelPrefab;
    public Transform labelRoot;

    public int minHeight = 5;
    public int maxHeight = 540;

    public AudioSource audioSource;

    [Space(20), Range(64, 8192)]
    public int dataLen = 64;

    /** 显示的频带数 */
    public int showLen = 80;

    public RectTransform[] cubes = { };

    // Start is called before the first frame update
    void Start()
    {
        audioSource = new GameObject("Audio Source").AddComponent<AudioSource>();
        if (!clip)
        {
            return;
        }

        audioSource.clip = clip;
        audioSource.Play();

        //vis = GetComponentsInChildren<VisualObject>();

        initCubes();
    }

    private void initCubes()
    {
        cubes = new RectTransform[showLen];
        for (int i = 0; i < showLen; i++)
        {
            RectTransform cube = Instantiate(imagePrefab, transform);
            cube.gameObject.SetActive(true);
            cubes[i] = cube;
        }

        for (int i = 0; i < showLen; i++)
        {
            Transform cube = Instantiate(labelPrefab, labelRoot);
            TextMeshProUGUI text = cube.GetComponent<TextMeshProUGUI>();
            cube.gameObject.SetActive(true);
            RectTransform t = cube.GetComponent<RectTransform>();
            text.text = i + "";
            text.fontSize = 5;
            //t.sizeDelta = new Vector2();
        }
    }


    // Update is called once per frame
    void Update()
    {
        float[] spectrumDatas = new float[dataLen];
        audioSource.GetSpectrumData(spectrumDatas, 0, windowType);

        for (int i = 0; i < cubes.Length; i++)
        {
            Rect rect = cubes[i].GetComponent<RectTransform>().rect;

            Vector2 size = rect.size;

            rect.y = Mathf.Lerp(size.y, minHeight + (maxHeight - minHeight) * spectrumDatas[i] * 2, 0.1f);
            Vector2 newSize = new Vector2(rect.x, rect.y);

            cubes[i].GetComponent<RectTransform>().sizeDelta = newSize;
        }
    }
}