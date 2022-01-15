using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRIGHT : MonoBehaviour
{

  //  public Health Health;
    public PlayerMovement playerMovement;

    bool attack = false;

    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;


    private void Update()
    {

        if (timeBtwAttack <= 0)
        {
            if (attack == true)
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<PlayerMovement>().TakeDamage(damage);
                    //Debug.Log("Collision Right RUNNING");
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
       // Physics2D.IgnoreCollision(collision.gameObject.GetComponent<BoxCollider2D>(), this.GetComponent<CircleCollider2D>());

     //  if(collision.gameObject.tag != "Archer")
      //  {
            if (collision.gameObject.name == "1(Clone)" || collision.gameObject.name == "2(Clone)" || collision.gameObject.name == "3(Clone)" || collision.gameObject.name == "4(Clone)" || collision.gameObject.name == "Special_4(Clone)")
            {
                attack = true;
               // Debug.Log("Running");
            }
        //}
       
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
