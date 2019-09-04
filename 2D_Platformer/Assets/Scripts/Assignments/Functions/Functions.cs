using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    int num1;
    int num2;
    int total;


    // Start is called before the first frame update
    void Start()
    {
        // firstName = "Jerry";
        // lastName = "Louis";
        // age = 420;

        // Customer(firstName, lastName, age);
        CalcAdd(21,23);

    }

    int CalcAdd(int one, int two)
    {
        total = one + two;
        Debug.Log(total);
        return total;
        
    } 

    // void Customer(string fName, string lName, int a)
    // {
    //     Debug.Log(fName + " " + lName + " " + a);
    // }
}
