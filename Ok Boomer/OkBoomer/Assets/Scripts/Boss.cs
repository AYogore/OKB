using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
	public Transform player;

	public bool isFlipped = false;
	public int speed;
	public int health;
	public GameObject end;
	public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
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
		end.SetActive(true);
		Destroy(gameObject);
	}

	private void Start()
	{
		InvokeRepeating("LookAtPlayer", 1 , 1);

	}
	private void Update()
	{
		transform.Translate(2 * Time.deltaTime * speed, 0, 0);

	}
}
