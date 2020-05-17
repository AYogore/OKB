using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public float speed;
    public GameObject deathEffect;
    public bool nearPlayer = false;
    public bool movingRight = true;
    public SpriteRenderer mySprite;

    public Transform firepointL;
    public GameObject bulletPrefabL;
    public Transform firepointR;
    public GameObject bulletPrefabR;

    public EnemyShoot shoot;

    public GameObject[] drops;

    private void Awake()
    {
        mySprite = GetComponent<SpriteRenderer>();
        mySprite.flipX = false;
        shoot = GetComponent<EnemyShoot>();
        
    }
    void Update()
    {
        Patrol();

       // if (nearPlayer == true)
           // Shoot();
       
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Turn"))
        {

            if (movingRight)
            {
                movingRight = false;
            }
            else
            {
                movingRight = true;
            }
        }

        
            
    }

    public virtual void Patrol()
    {
        if(movingRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            mySprite.flipX = false;
            shoot.firepoint = firepointR;
            shoot.bulletPrefab = bulletPrefabR;

        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            mySprite.flipX = true;
            shoot.firepoint = firepointL;
            shoot.bulletPrefab = bulletPrefabL;

        }
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate((drops[Random.Range(0, 3)]), transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
