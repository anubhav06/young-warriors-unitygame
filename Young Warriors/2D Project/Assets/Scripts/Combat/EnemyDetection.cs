/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour {

    public PlayerMovement playerMovement;

    //The targets are the enemy i.e. players of the RIGHT

    public float lookRadius = 10f;

    Transform target1;
    Transform target2;
    Transform target3;
    Transform target4;

    Transform player1;

    private void Start()
    {
        target1 = PlayerManager.instance.player1.transform;
        target2 = PlayerManager.instance.player2.transform;
        target3 = PlayerManager.instance.player3.transform;
        target4 = PlayerManager.instance.player4.transform;

    }

    private void Update()
    {
        float distance1 = Vector2.Distance(transform.position, target1.position);
        float distance2 = Vector2.Distance(transform.position, target2.position);
        float distance3 = Vector2.Distance(transform.position, target3.position);
        float distance4 = Vector2.Distance(transform.position, target4.position);

        if ((distance1 <= lookRadius))// || (distance2 <= lookRadius) || (distance3 <= lookRadius) || (distance4 <= lookRadius) )
        {
            Attack();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void Attack()
    {

        playerMovement.runSpeed = 0f;
        //Debug.Log("Enemy detected ");
    }

}
*/