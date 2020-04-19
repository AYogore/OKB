using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    private void Start()
    {

        InvokeRepeating("Shoot", 1, 1);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
