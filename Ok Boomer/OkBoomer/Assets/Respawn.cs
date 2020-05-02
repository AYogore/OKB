using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject respawnPoint;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Player player = coll.GetComponent<Player>();
        if (player.tag == "Player")
        {
            player.TakeDamage(1);
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
