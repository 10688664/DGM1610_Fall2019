using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float zBounds = -18;

    private GameObject player;
    private PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerController>();
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
        
        if(playerScript.hasPowerup == true)
        {
            Destroy(gameObject);
        }
        else if(playerScript.hasPowerup == false)
        {
            Destroy(player);
            Destroy(gameObject);
        }
    }
}
