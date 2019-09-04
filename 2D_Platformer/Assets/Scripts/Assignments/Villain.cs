using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villain : MonoBehaviour
{
    string name = "Fluffiest Dandie";
    float height = 6.8f;
    bool superpower = true;
    string superpowerName = "Impervious Shield";
    int age = 48;

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