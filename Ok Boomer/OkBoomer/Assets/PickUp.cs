using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp : MonoBehaviour
{
    public Text scoreText;
    int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        Display();
    }
    private void OnTriggerEnter2D(Collider2D pickup)
    {
        if (pickup.tag == "PickUp")
        {
            score++;
        }
    }

    public void Display()
    {
        scoreText.text = $"Score = {score}";
    }
}
