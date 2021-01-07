using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    // Sound
    private AudioSource source;
    public AudioClip buttonSound;

    public bool on = false;
    public bool buttonHit = false;
    private GameObject button;

    private float buttonDownDistance = 0.025f;
    private float buttonReturnSpeed = 0.001f;
    private float buttonOriginalY;

    public Light spotLight;

    //Button can be hit again timer
    private float buttonHitAgainTimer = 0.5f;
    private float canHitAgain;

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();


        button = transform.GetChild(1).gameObject;
        buttonOriginalY = button.transform.position.y;


        //turn off spotlight
        spotLight.enabled = false;
    }
    private void Update()
    {
        if (buttonHit)
        {
            source.PlayOneShot(buttonSound);

            buttonHit = false;

            on = !on;

            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - buttonDownDistance, button.transform.position.z);

            if (on)
            {
                spotLight.enabled = true;
            }else 
            {
                spotLight.enabled = false;
            }
        }
        if (button.transform.position.y < buttonOriginalY)
        {
            button.transform.position += new Vector3(0, buttonReturnSpeed, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand") && canHitAgain < Time.time)
        {
            canHitAgain = Time.time + buttonHitAgainTimer;
            buttonHit = true;
        }
    }

}
