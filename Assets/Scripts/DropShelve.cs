using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropShelve : MonoBehaviour
{
    public SwitchControll Switch;

    private void Update()
    {
        if (Switch.on == true)
	    {
            Destroy(gameObject);
        }
    }
    

}
