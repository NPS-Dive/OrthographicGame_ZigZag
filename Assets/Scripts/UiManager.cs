using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
    {
    public OrbController Orb;
    public AudioSource BackgroundMusic;
    public Slider BackgroundMusicSlider;
    public Toggle SoundFxToggle;
    public AudioManager ZigzagAudioManager;
    // Start is called before the first frame update
    void Start ()
        {

        }

    // Update is called once per frame
    void Update ()
        {
        AdjustBackgroundMusicVolume();
        }

    public void StartGame ()
        {
        Orb.IsGameStart = true;
        }

    public void AdjustBackgroundMusicVolume ()
        {
        BackgroundMusic.volume = BackgroundMusicSlider.value;
        }

    public void SoundFxOnOff ()
        {
        ZigzagAudioManager.ZigZagAudioSource.mute = SoundFxToggle.isOn;
        }

        public void RestartGame()
        {
            SceneManager.LoadScene("GameMainScene");
        }
    }
