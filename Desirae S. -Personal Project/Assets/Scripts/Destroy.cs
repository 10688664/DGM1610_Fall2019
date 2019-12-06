using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float zBounds = -18;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // destroy projectile if goes out of bounds
    void Update()
    {
        if(transform.position.z < zBounds)
        {
            Destroy(gameObject);
        }
    }

    //destroy projectile upon hit
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        Destroy(player);
    }
}
