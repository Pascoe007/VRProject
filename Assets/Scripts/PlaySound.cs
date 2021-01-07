using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    

    public AudioClip soundToPlay;
    public float soundVolume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    bool playerIn = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (!alreadyPlayed && playerIn)
        {
            audio.PlayOneShot(soundToPlay, soundVolume);
            alreadyPlayed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerIn = true;
        }
    }
}
