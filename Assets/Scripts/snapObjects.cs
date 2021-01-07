using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapObjects : MonoBehaviour
{

    public GameObject[] snapZone;
    public bool snapped;
    bool grabbed;
    

    void Start()
    {
        snapZone = GameObject.FindGameObjectsWithTag("SnapZone");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SnapZone")
        {
            snapped = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "SnapZone")
        {
            snapped = false;
        }
    }

    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;
        for (int i = 0; i < snapZone.Length; i++)
        {
            if (Vector3.Distance(snapZone[i].transform.position, transform.position) < 0.5f)
            {
                if (snapped && !grabbed)
                {
                    transform.position = snapZone[i].transform.position;
                    transform.rotation = snapZone[i].transform.rotation;
                    GetComponent<Rigidbody>().useGravity = false;
                }
                else
                {
                    GetComponent<Rigidbody>().useGravity = true;
                }
            }
        }
    }
}
