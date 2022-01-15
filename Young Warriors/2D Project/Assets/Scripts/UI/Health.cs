﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health = 100;

    //public GameObject deathEffect;

    public void TakeDamage( int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        Debug.Log(health);
    }

    void Die()
    {
        Destroy(gameObject); // Instantiate(transform.position, Quaternion.identity);
    }
}
