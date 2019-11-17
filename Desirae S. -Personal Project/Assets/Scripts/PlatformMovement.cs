using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlatform();
    }

    void RotatePlatform()
    {
       transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
}
