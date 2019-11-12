using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
<<<<<<< HEAD
    public bool hasPowerup = false;
    public GameObject powerupIndicator;

    private GameObject focalPoint;
    private Rigidbody playerRb;
    private float powerupStr = 15.0f;
    private Vector3 powerupOffset = new Vector3(0, -0.5f, 0);
=======

    private GameObject focalPoint;
    private Rigidbody playerRb;
>>>>>>> master

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
<<<<<<< HEAD

        //sets powerup indicator to player position
        powerupIndicator.transform.position = transform.position + powerupOffset;
    }

    private void OnTriggerEnter(Collider other) 
    {
      if(other.CompareTag("Powerup"))
      {
          hasPowerup = true;
          powerupIndicator.gameObject.SetActive(true);
          Destroy(other.gameObject);
          StartCoroutine(PowerupCountdownRoutine());
      }  
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(6);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRb.AddForce(awayFromPlayer * powerupStr, ForceMode.Impulse);
        }    
=======
>>>>>>> master
    }
}
