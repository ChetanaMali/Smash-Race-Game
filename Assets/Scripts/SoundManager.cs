using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }

    [SerializeField] AudioSource audioSource;
    //[SerializeField] AudioSource backAudioSource;
    [SerializeField] AudioClip jump, music;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        //backAudioSource = GetComponent<AudioSource>();
        //BackGroundMusic();
    }
    public void BackGroundMusic()
    {
        audioSource.clip = music;
        audioSource.Play();
    }
    public void JumpSfx()
    {
        audioSource.clip = jump;
        audioSource.Play();
    }
}
