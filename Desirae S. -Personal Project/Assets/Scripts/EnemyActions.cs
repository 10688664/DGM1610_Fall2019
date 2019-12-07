using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    public float minRange;
    public float maxRange;
    public float fireRate;

    public bool fireWait = false;

    public GameObject projectile;
    public PlayerController playerPowerup;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerPowerup = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootPlayer();
    }

    /*private void OnCollisionEnter(Collision other) 
    {
        if(playerPowerup.hasPowerup && player.gameObject)
        {
            Destroy(gameObject);
        }   
    }*/

    IEnumerator ShotCountdownRoutine()
    {
        fireWait = true;
        yield return new WaitForSeconds(fireRate);
        Instantiate(projectile, transform.position, projectile.transform.rotation);
        fireWait = false;
    }

    void ShootPlayer()
    {
        if((Vector3.Distance(transform.position, player.transform.position) < maxRange) && (Vector3.Distance(transform.position, player.transform.position) > minRange))
        {
            transform.LookAt(player.transform.position);   

            if(!fireWait)
            {
                StartCoroutine(ShotCountdownRoutine());
            }
        }
    }
}
