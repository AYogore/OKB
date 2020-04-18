﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    private void OnTriggerEnter2D(Collider2D player)
    {
        Shoot();
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
