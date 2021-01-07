using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSound : MonoBehaviour
{
    public AudioClip soundToPlay;
    public float soundVolume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    bool playerIn = false;
    public bool grabbed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (!alreadyPlayed && grabbed)
        {
            audio.PlayOneShot(soundToPlay, soundVolume);
            alreadyPlayed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerHand")
        {
            grabbed = true;
        }
    }

}
