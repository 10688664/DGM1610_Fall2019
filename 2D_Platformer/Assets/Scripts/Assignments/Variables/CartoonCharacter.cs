using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartoonCharacter : MonoBehaviour
{
    string characterName = "Larry";
    float height = 1.9f;
    bool superpower = true;
    string superpowername = "ageless";
    int age = 1000;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cartoon Character's name:" + characterName);
        Debug.Log("Cartoon Character's height:" + height);
        Debug.Log("Character's superpower:" + superpower);
        Debug.Log("Superpower:" + superpowername);
        Debug.Log("Character's age:" + age);
        
    }

}
