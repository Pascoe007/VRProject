using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGrabble : OVRGrabbable
{
    public Transform hander;
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);
        transform.position = hander.transform.position;
        transform.rotation = hander.transform.rotation;


        Rigidbody rbhander = hander.GetComponent<Rigidbody>();
        rbhander.velocity = Vector3.zero;
        rbhander.angularVelocity = Vector3.zero;
    }

    private void Update()
    {
        if (Vector3.Distance(hander.position, transform.position) > 0.4f)
        {
            grabbedBy.ForceRelease(this);
        }
    }
}
