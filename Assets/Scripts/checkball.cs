using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkball : MonoBehaviour
{
    public float wHoop = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        Debug.Log("This hope is " + wHoop);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            if(gameObject.tag == "Hoop1")
            {
                wHoop = 1;
            }
            else if (gameObject.tag == "Hoop2")
            {
                wHoop = 2;
            }
            else if (gameObject.tag == "Hoop3")
            {
                wHoop = 3;
            }
            switch (wHoop)
            {
                default:
                    GetComponentInParent<HoopNumber>().hoopNum = 0;
                    break;
                case 1:
                    GetComponentInParent<HoopNumber>().hoopNum = 1;
                    break;
                case 2:
                    GetComponentInParent<HoopNumber>().hoopNum = 2;
                    break;
                case 3:
                    GetComponentInParent<HoopNumber>().hoopNum = 3;
                    break;
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        wHoop = 0;
    }
}
