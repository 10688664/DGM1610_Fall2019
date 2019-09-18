using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotateSpeed = 100.0f;
    public Vector3 propellerOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate = propeller.transform.position + propellerOffset;
        //transform.Rotate(Vector3. * Time.deltaTime * rotateSpeed);
    }
}
