using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    public float minRange;
    public float maxRange;
    
    public GameObject projectile;

    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootPlayer();
    }

    void ShootPlayer()
    {
        if((Vector3.Distance(transform.position, player.transform.position) < maxRange) && (Vector3.Distance(transform.position, player.transform.position) > minRange))
        {
            transform.LookAt(player.transform.position);
            Instantiate(projectile, transform.position, projectile.transform.rotation);
            StartCoroutine(ShotCountdownRoutine());
        }
    }

    IEnumerator ShotCountdownRoutine()
    {
        yield return new WaitForSeconds(6);
    }
}
