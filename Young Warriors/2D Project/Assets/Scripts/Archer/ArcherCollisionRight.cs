using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCollisionRight : MonoBehaviour {


    public bool enemyFound = false;

    public PlayerMovementRIGHT playerMovement;

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

        Collider2D[] enemiesToDamage = Physics2D.OverlapBoxAll(attackPos2.position, new Vector2(attackLength, attackBreadth), 0, whatIsEnemies2);
        for (int i = 0; i < enemiesToDamage.Length; i++)
        {
            enemyFound = true;

            if (enemiesToDamage[i].GetComponent<PlayerMovement>().health >= 5)     // idk why 5 ..... >0 not working 
            {
                this.playerMovement.runSpeed = 0f;
            }

            else                                                                                
            {
                enemyFound = false;
                this.playerMovement.runSpeed = this.playerMovement.initialRunSpeed;
            }
        }


        if (enemyFound == true)
        {
            if (timeBtwShots <= 0)
            {
                Instantiate(projectile, shotPoint.position, projectile.transform.rotation);

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
        Gizmos.DrawWireCube(attackPos2.position, new Vector2(attackLength, attackBreadth));
    }
}


