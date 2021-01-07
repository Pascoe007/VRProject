using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    bool buttonPressed = false;
    Vector3 move;
    Renderer rend;
    public GameObject[] Button;
    void Start()
    {
        rend = GetComponent<Renderer>();
        Button = GameObject.FindGameObjectsWithTag("Button");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Button")
        {
            buttonPressed = true;
            //rend.material.color = Color.green;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Button")
        {
            buttonPressed = false;
        }
    }
    void Update()
    {

        Debug.Log(buttonPressed);
        

        for (int i = 0; i < Button.Length; i++)
        {
           
            if (Vector3.Distance(Button[i].transform.position, transform.position) < 0.5f) 
            {
                if (buttonPressed)
                {
                    move = Button[i].transform.position;
                    for (int ii = 1; ii < 10; ii++)
                    {
                        //move.x = ii / 100;
                        //Button[i].transform.position = move;
                        Debug.Log(Button[i].transform.position);
                        Debug.Log(move);
                    }
                    
                    
                }
                
            }
        }
    }
}
