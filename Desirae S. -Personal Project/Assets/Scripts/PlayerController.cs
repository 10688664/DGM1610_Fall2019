﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public float powerupRate = 3.0f;

    public bool isOnGround = true;
    public bool hasPowerup = false;

    public Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {   
        //Moves player with arrow keys if on ground
        float horizontalInput = Input.GetAxis("Horizontal");
        if(isOnGround)
        {
            playerRb.AddForce(Vector3.forward * speed * horizontalInput, ForceMode.Force);
        }
 
        //Player jumps
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    //Ground bool = true if player is colliding with ground
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }    
    }

    //Power up timer and destroys powerup
    //If player has power up player can kill the enemy
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy" && hasPowerup == true)
        {
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            StartCoroutine(PowerupTimer());
            Destroy(other.gameObject);
        } 

    }

    IEnumerator PowerupTimer()
    {
        if(hasPowerup == true)
        {
            yield return new WaitForSeconds(powerupRate);
            hasPowerup = false;
        }
    }
}
