using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    public float speed;
    public float maxRange;
    public float minRange;

    private Rigidbody sheepRb;
    private GameObject player;

    
    void Start()
    {
        sheepRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveSheep();
    }

    //Moves sheep away from player
    void MoveSheep()
    {
        if((Vector3.Distance(transform.position, player.transform.position) < maxRange) && (Vector3.Distance(transform.position, player.transform.position) > minRange))
        {
            Vector3 lookDirection = (transform.position - player.transform.position).normalized;
            sheepRb.AddForce(lookDirection * speed, ForceMode.Impulse);
        }
        
    }

    //Sheep dies if player collides
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }    
    }

}
