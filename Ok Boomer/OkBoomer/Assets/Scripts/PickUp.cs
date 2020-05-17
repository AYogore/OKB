using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp : MonoBehaviour
{
    public Text scoreText;
    public Text ammoText;
    int score;
    public int ammo;
    public Player p;
    public PlayerMovement pm;
    public PlayerShoot ps;

    private void Start()
    {
        score = 0;
        ammo = 0;
        p = GetComponent<Player>();
        pm = GetComponent<PlayerMovement>();
        ps = GetComponent<PlayerShoot>();
    }

    private void Update()
    {
        Display();
        if(ammo == 0)
        {
            pm.hasAmmo = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D pickup)
    {
        if (pickup.tag == "PickUp")
        {
            score++;
        }
        if(pickup.tag == "Ammo")
        {
            ammo += 5;
            pm.hasAmmo = true;
            ps.ammo += 5;

        }
        if(pickup.tag == "LifeUP")
        {
            p.health++;
        }
    }

    public void Display()
    {
        scoreText.text = $" = {score}";
        ammoText.text = $" = {ammo}";
    }
}
