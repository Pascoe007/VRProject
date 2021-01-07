using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControll : MonoBehaviour
{
    [SerializeField] ParticleSystem Sparks = null;
    // Sound
    private AudioSource source;
    public AudioClip switchSound;

    public bool on = false;
    public bool switchHit;
    private float switchRotation = 100;
    private GameObject switchBase;
    public bool resistorOn;

    public DoorControll DC;



    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        switchBase = transform.GetChild(0).gameObject;
    }
    private void Update()
    {
        //resistorOn = GetComponentInParent<CheckItem>().resistorIn;

        if (switchHit == true)
        {
            source.PlayOneShot(switchSound);
            switchHit = false;
            on = !on;
            //DC.SP = true;

            if (on == true)
            {
                Collect();
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + switchRotation);
            }
            else
            {
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - switchRotation);
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            switchHit = true;
        }
    }
    private void Collect()
    {
        Sparks.Play();
    }
}
