using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero : MonoBehaviour
{
    string name = "Captain Murder";
    float height = 5.4f;
    bool superpower = true;
    string superpowerName = "Death touch";
    int age = 12;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Superhero name: " + name);
        Debug.Log("Superhero height: " + height);
        Debug.Log("Do they have a superpower: " + superpower);
        Debug.Log("What's their superpower: " + superpowerName);
        Debug.Log("Age: " + age);

    }

}
