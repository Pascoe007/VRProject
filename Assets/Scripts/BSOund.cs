using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSOund : MonoBehaviour
{
    public ButtonControll button;
    public CheckItem Check;
    public AudioClip soundToPlay;
    public AudioClip soundToPlay2;
    public float soundVolume;
    AudioSource audio;
    AudioSource audio2;
    public bool alreadyPlayed = false;
    bool playerIn = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio2 = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (!alreadyPlayed && playerIn && button.on && Check.capIn == false)
        {
            audio.PlayOneShot(soundToPlay, soundVolume);
            alreadyPlayed = true;
        }
        if (!alreadyPlayed && playerIn && button.on && Check.capIn)
        {
            audio.PlayOneShot(soundToPlay2, soundVolume);
            alreadyPlayed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = true;
        }
    }
}
