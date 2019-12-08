using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    public float speed;
    public float maxRange;
    public float minRange;

    public GameManager gameManagerScript;

    private Rigidbody sheepRb;
    private GameObject player;
    private GameObject gameManager;

    
    void Start()
    {
        sheepRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("Game Manager");
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            MoveSheep();
        }
        
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
            gameManagerScript.UpdateScore(1);
        }    
    }

}
