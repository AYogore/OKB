using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject firstText;
    public GameObject nextText;
    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.tag == "Player")
        {
            firstText.SetActive(false);
            nextText.SetActive(true);
        }
        

    }
}
