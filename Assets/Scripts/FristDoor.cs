using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristDoor : MonoBehaviour
{
    public SwitchControll Switch;
    bool doorOpen = true;
    public float doorMove;

    // Update is called once per frame
    void Update()
    {
        if (Switch.on)
        {
            if (doorOpen == true)
            {
                doorOpen = false;
                Debug.Log("Door is activbe");
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + doorMove, transform.eulerAngles.z);
            }
        }
    }
}
