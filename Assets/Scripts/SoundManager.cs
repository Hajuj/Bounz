using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip jump;
    public static AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        
    }

    public static void PlaySound()
    {
        Debug.Log("playing jump sound");
        jump = Resources.Load<AudioClip>("Sounds/jump");
        source.PlayOneShot(jump);
    }
}
