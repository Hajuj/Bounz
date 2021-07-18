using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip jump;
    public static AudioClip splash;
    public static AudioClip ring;
    public static AudioClip check;
    public static AudioClip life;
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

    public static void PlayLifeSound()
    {
        Debug.Log("playing life sound");
        life = Resources.Load<AudioClip>("Sounds/life");
        source.PlayOneShot(life);
    }
    
    public static void PlayRingSound()
    {
        Debug.Log("playing ring sound");
        ring = Resources.Load<AudioClip>("Sounds/ring");
        source.PlayOneShot(ring);
    }

    public static void PlayCheckSound()
    {
        Debug.Log("playing check sound");
        check = Resources.Load<AudioClip>("Sounds/check");
        source.PlayOneShot(check);
    }
}
