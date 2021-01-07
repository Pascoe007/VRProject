using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHands : MonoBehaviour
{
    private bool grabbed;
    void Start()
    {
        
    }


    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

        if (grabbed) 
        { 
            
        }
    }
}
