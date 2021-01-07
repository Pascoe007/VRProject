using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll2 : MonoBehaviour
{
    
    public CheckItem Check;
    public ButtonControll Button;

    

    bool doorOpen = true;
    

    public float doorMove;

    private void Start()
    {
        
    }

    void Update()
    {
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

