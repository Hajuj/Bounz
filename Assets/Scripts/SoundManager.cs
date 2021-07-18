using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip jump;
    public static AudioClip splash;
    public static AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public static void PlayJumpSound()
    {
        Debug.Log("playing jump sound");
        jump = Resources.Load<AudioClip>("Sounds/jump");
        source.PlayOneShot(jump);
    }

    public static void PlaySplashSound()
    {
        Debug.Log("playing splash sound");
        splash = Resources.Load<AudioClip>("Sounds/splash");
        source.PlayOneShot(splash);
    }
}
