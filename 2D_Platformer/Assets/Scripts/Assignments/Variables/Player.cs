using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string characterName = "Desirae";
    int age = 24;
    float height = 5.8f;
    bool married = false;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + characterName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Married: " + married);
    }

    
}
