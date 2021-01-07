using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCollision : MonoBehaviour
{
    public Transform Stairs;

    void Start()
    {
        Physics.IgnoreCollision(Stairs.GetComponent<Collider>(), GetComponent<Collider>());
    }


}
