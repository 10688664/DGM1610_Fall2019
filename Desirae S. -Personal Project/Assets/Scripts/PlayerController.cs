using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public float powerupRate = 3.0f;

    public bool isOnGround = true;
    public bool hasPowerup = false;

    private Rigidbody playerRb;

    private GameObject enemy;

    public ParticleSystem powerUpEffect;

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI movementText;

    public AudioClip jumpSound;
    private AudioSource playerAudio;

    void Start()
    {
        enemy = GameObject.Find("Enemy");
        playerRb = GetComponent<Rigidbody>();
        powerUpEffect.Stop();
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        MovePlayer();   
    }

    void MovePlayer()
    {   
        //Moves player with arrow keys if on ground
        float horizontalInput = Input.GetAxis("Horizontal");

        if(horizontalInput != 0.0)
        {
            titleText.enabled = false;
            movementText.enabled = false;
        }

        if(isOnGround)
        {
            playerRb.AddForce(Vector3.forward * speed * horizontalInput, ForceMode.Force);
        }
 
        //Player jumps
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
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


        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerUpEffect.Play();
            StartCoroutine(PowerupTimer());
            Destroy(other.gameObject);
        } 

    }

    IEnumerator PowerupTimer()
    {
        if(hasPowerup == true)
        {
            yield return new WaitForSeconds(powerupRate);
            powerUpEffect.Stop();
            hasPowerup = false;
        }
    }
}
