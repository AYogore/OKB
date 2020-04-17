using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            Destroy(gameObject);

        }
    }

}
