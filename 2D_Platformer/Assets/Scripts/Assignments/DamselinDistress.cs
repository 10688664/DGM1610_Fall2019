using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamselinDistress : MonoBehaviour
{
    string name = "Rocky";
    float height = 7f;
    bool superpower = false;
    string description = "Doesn't save himself because he's lazy";
    int age = 24;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Damsel's name:" + name);
        Debug.Log("Damsel's height:" + height);
        Debug.Log("Damsel's age:" + age);
        Debug.Log("Damsel's Superpower:" + superpower);
        Debug.Log("Damsel's description:" + description);
 
    }

}
