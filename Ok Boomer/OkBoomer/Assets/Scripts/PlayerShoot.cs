using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public GameObject punchPrefab;
    public int ammo;
    public PickUp pickUp;
    public PlayerMovement pm;
    public Animator anim;
    
    void Start()
    {
        ammo = 0;
        pickUp = GetComponent<PickUp>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            if (ammo > 0)
            {
                Shoot();
                ammo--;
                pickUp.ammo--;
            }
            else
            {
                Punch();
                //Punch Animation
                anim.SetTrigger("isPunching");

            }
        }
        
        
        
    }
    
    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
    void Punch()
    {
        Instantiate(punchPrefab, firepoint.position, firepoint.rotation);
    }
}
