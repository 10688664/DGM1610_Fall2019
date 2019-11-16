using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private float zBound = 18;
    private float zBoundAlt = 54;


    void Update()
    {
        ContraintPlayerPosition();
    }

    void ContraintPlayerPosition()
    {
        if (transform.position.z > zBoundAlt)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundAlt);
        }
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
    }
}
