using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 1;
    public float speed;
    public GameObject deathEffect;
    public Rigidbody2D rb;
    public float fallMultiplierFloat;


    public int numOFHearts;

    public Image[] hearts;
    public Sprite full;
    public Sprite empty;

    public int ammo;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity += Vector2.up * Physics.gravity.y * (fallMultiplierFloat - 1) * Time.deltaTime;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = full;
            }
            else
            {
                hearts[i].sprite = empty;
            }
            if (i < numOFHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if(ammo > 0)
        {
            PlayerMovement playerMovement = GetComponent<PlayerMovement>();
            playerMovement.hasAmmo = true;
        }    
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Time.timeScale = 0;
        deathEffect.SetActive(true);
    }
}
