using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class SettingsManager : MonoBehaviour
{
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mainAudioMixer;

    void Start()
    {
        
    }

    public void ChangeMasterVolume()
    {
        float volume = masterVol.value;
        mainAudioMixer.SetFloat("MasterVol", Mathf.Log10(volume) * 20);
    }

    public void ChangeMusicVolume()
    {
        float volume = musicVol.value;
        mainAudioMixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
    }

    public void ChangeSFXVolume()
    {
        float volume = sfxVol.value;
        mainAudioMixer.SetFloat("SFxVol", Mathf.Log10(volume) * 20);
    }

    void Update()
    {
        
    }
}