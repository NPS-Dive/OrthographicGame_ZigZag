using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource ZigZagAudioSource;
    public AudioClip BtnClickAudioClip;
    public AudioClip GameOverAudioClip;
    public AudioClip GetGemAudioClip;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayBtnClickSound()
    {
        ZigZagAudioSource.clip = BtnClickAudioClip;
        ZigZagAudioSource.Play();
    }

    public void PlayGameOverSound()
    {
        ZigZagAudioSource.clip = GameOverAudioClip;
        ZigZagAudioSource.Play();
    }

    public void PlayGetGemSound()
    {
        ZigZagAudioSource.clip = GetGemAudioClip;
        ZigZagAudioSource.Play();
    }
}
