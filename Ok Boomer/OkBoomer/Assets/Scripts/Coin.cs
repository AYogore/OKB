using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    AudioSource coin;
    private void Start()
    {
        coin = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            coin.Play();
            Destroy(gameObject);

        }
    }

}
