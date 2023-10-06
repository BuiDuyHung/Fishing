using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip firstAudioClip; 
    public AudioClip secondAudioClip; 
    private AudioSource audioSource;
    private bool isPlayingFirstClip;
    private float timer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = firstAudioClip;
        isPlayingFirstClip = true;
        timer = 0f;
        audioSource.Play(); 
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (isPlayingFirstClip && timer >= 8.0f)
        {
            SwitchToSecondClip();
        }
        else if (!isPlayingFirstClip && timer >= 9.0f)
        {
            StopAudio();
        }
    }

    void SwitchToSecondClip()
    {
        audioSource.clip = secondAudioClip;
        audioSource.Play();
        isPlayingFirstClip = false;
        timer = 0f;
    }

    void StopAudio()
    {
        audioSource.Stop();
    }
}
