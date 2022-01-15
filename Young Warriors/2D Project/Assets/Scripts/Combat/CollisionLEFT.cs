using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLEFT : MonoBehaviour {


    public PlayerMovementRIGHT playerMovement;

    bool attack = false;

    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;

    private void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if(attack == true)
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().TakeDamage(damage);
                  //  Debug.Log("Collision Left RUNNING");
                }
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.name == "Right_1(Clone)" || collision.gameObject.name == "Right_2(Clone)" || collision.gameObject.name == "Right_3(Clone)" || collision.gameObject.name == "Right_4(Clone)" || collision.gameObject.name=="Special_2(Clone)")
         {
              attack = true;
         }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
