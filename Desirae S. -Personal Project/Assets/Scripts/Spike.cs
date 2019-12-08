using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private GameObject player;
    private GameObject gameManager;

    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("Game Manager");
        gameManagerScript = gameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject == player)
        {
            Destroy(player);
            gameManagerScript.GameOver();
        }
       
    }
}
