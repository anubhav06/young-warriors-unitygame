using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCollisionLeft : MonoBehaviour {

    public bool enemyFound = false;

    public PlayerMovement playerMovement;

    public GameObject projectile;
    public Transform shotPoint;

    public float timeBtwShots;
    public float startTimeBtwShots;

    public Transform attackPos2;
    public float attackLength;
    public float attackBreadth;
    public LayerMask whatIsEnemies2;

    
    private void Update()
    {

        Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos2.position, new Vector2(attackLength,attackBreadth),0, whatIsEnemies2);
        for (int i = 0; i < enemiesToDamage.Length; i++)
        {
            enemyFound = true;


            if (enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().health >= 5)             // idk why 5 ..... >0 not working 

            {
                this.playerMovement.runSpeed = 0f;
               // Debug.Log(enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().health);
            }

            else                                                                                 //if(enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().health <= 0)
            {
                enemyFound = false;
                this.playerMovement.runSpeed = this.playerMovement.initialRunSpeed;
               // Debug.Log("Enemy Destroyed");
            }


            //To calculate velocity of projectile:
/*
            x = Mathf.Abs(enemiesToDamage[i].transform.position.x - this.transform.position.x);

           // dispX = ( 7 - ( (enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().temprunSpeed) * t ) );  // dispX = 7- (velocity)t

            d= Mathf.Pow(enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().temprunSpeed, 2) + (11.36f * x);
            rootD = Mathf.Sqrt(d);

            t = ( ( ( -1f * (enemiesToDamage[i].GetComponent<PlayerMovementRIGHT>().temprunSpeed) ) + rootD) / 5.68f );

           // Debug.Log("Distance: " + x + ", d: " + d + ", rootD: " + rootD + ",t: " + t + ",Velocity: " + velocity);
*/    
            //End vel projectile
        }

        
        if (enemyFound == true)
        {
            if(timeBtwShots<=0)
            {
                Instantiate(projectile, shotPoint.position, projectile.transform.rotation);
            //    GameObject.Find("Arrow(Clone)").GetComponent<Arrow>().fireProjectile();
             //   projectile.GetComponent<Arrow>().rb.velocity = transform.right * 5.56f;
  
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(attackPos2.position, new Vector2(attackLength,attackBreadth));
    }
}
