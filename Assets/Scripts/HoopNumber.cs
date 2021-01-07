using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopNumber : MonoBehaviour
{

    public AudioClip soundToPlay;
    public float soundVolume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    public float hoopNum;
    public bool hoop1 = false;
    public bool hoop2 = false;
    public bool hoop3 = false;

    public GameObject LED;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (hoopNum)
        {
            case 1:
                hoop1 = true;
                break;
            case 2:
                hoop2 = true;
                break;
            case 3:
                hoop3 = true;
                break;
            default:
                
                break;
        }

        if (hoop1 && hoop2 && hoop3)
        {
            if (!alreadyPlayed)
            {
                alreadyPlayed = false;
                audio.PlayOneShot(soundToPlay, soundVolume);
            }
            hoop1 = false;
            hoop2 = false;
            hoop3 = false;
            LED.GetComponent<Rigidbody>().isKinematic = false;
            LED.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
