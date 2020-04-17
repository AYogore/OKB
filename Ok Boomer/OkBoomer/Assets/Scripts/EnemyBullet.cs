using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;

    public GameObject target;
    Vector2 moveDirection;
    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player");
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = moveDirection;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
    }

}
