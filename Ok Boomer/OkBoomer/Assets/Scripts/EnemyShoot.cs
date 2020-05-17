using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public int SecondsToRepeat;
    private void Start()
    {

        InvokeRepeating("Shoot", 1, SecondsToRepeat);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
