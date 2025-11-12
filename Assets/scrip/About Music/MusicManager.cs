using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{
    public AudioSource[] musicTracks;
    private int currentTrackIndex = 0;

    void Start()
    {
        // 開始播放第一個音樂曲目
        Button button = GetComponent<Button>();

        // 添加按钮点击事件处理程序
        button.onClick.AddListener(PlayNextMusic);
    }

    public void PlayMusic(int trackIndex)
    {
        // 停止當前的音樂
        if (musicTracks[currentTrackIndex].isPlaying)
        {
            musicTracks[currentTrackIndex].Stop();
        }

        // 播放新的音樂曲目
        musicTracks[trackIndex].Play();
        currentTrackIndex = trackIndex;
    }

    public void PauseMusic()
    {
        musicTracks[currentTrackIndex].Pause();
    }

    public void ResumeMusic()
    {
        musicTracks[currentTrackIndex].UnPause();
    }

    public void PlayNextMusic()
    {
        // 切換到下一首音樂
        currentTrackIndex = (currentTrackIndex + 1) % musicTracks.Length;
        PlayMusic(currentTrackIndex);
    }
}
