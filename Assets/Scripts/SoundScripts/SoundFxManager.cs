using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager Instance;

    [SerializeField] private AudioSource soundFXObjec;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        AudioSource audioSource = Instantiate(soundFXObjec, spawnTransform.position, Quaternion.identity);
        audioSource.clip = audioClip;  
        audioSource.volume = volume;
        audioSource.Play();
        float clipLength = audioSource.clip.length; 
        Destroy(audioSource.gameObject, clipLength);
    }
}