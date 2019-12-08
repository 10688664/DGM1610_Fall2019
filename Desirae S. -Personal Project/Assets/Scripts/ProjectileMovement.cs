using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed = 40.0f;

    private GameObject player;


    void Start()
    {
        player = GameObject.Find("Player");
    }
    
    void Update()
    {
        if(player != null)
        {
            transform.LookAt(player.transform.position);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
