using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckItem : MonoBehaviour
{

    [SerializeField] ParticleSystem Sparks = null;

    private AudioSource source;
    public AudioClip sparkSound;

    public SwitchControll Switch;
    public ButtonControll Button;


    public bool resistorIn = false;
    public bool capIn = false;
    public char itemTag;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Resistor")
        {
            resistorIn = true;
        }
        if (other.gameObject.tag == "Capacitor")
        {
            capIn = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Resistor")
        {
            resistorIn = false;
            
        }
        else if (other.gameObject.tag == "Capacitor")
        {
            capIn = false;
        }
    }

    private void Update()
    {
        if (Switch.on == false && resistorIn == false || Button.on == false && capIn == false) 
        {
            Sparks.Play();
        }
    }

}
