using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll : MonoBehaviour
{
    public SwitchControll Switch;
    public CheckItem Check;
    public ButtonControll Button;

    private AudioSource source;
    public AudioClip doorSound;

    bool doorOpen = true;
    bool on = false;
   
    public float doorMove;

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
       

        if (Switch.on && Check.resistorIn)
        {
            if (doorOpen == true)
            {
                doorOpen = false;
                Debug.Log("Door is activbe");
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - doorMove, transform.eulerAngles.z);
                
            } 
        }
        if (Check.capIn && Button.on)
        {
            Debug.Log("Door is activbe");
            if (doorOpen == true)
            {
                doorOpen = false;
                Debug.Log("Door is activbe");
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - doorMove, transform.eulerAngles.z);
            }
        }
    }
}
