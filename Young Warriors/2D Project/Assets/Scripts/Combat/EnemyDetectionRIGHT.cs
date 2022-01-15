/*using UnityEngine;

public class EnemyDetectionRIGHT : MonoBehaviour
{
    //The targets are the enemy i.e. players of the LEFT
    public PlayerMovementRIGHT playerMovementRIGHT;

    public float lookRadius = 10f;

    Transform target1;
    Transform target2;
    Transform target3;
    Transform target4;

    private void Start()
    {
        target1 = PlayerManagerRIGHT.instance.player1.transform;
        target2 = PlayerManagerRIGHT.instance.player2.transform;
        target3 = PlayerManagerRIGHT.instance.player3.transform;
        target4 = PlayerManagerRIGHT.instance.player4.transform;

        Debug.Log("Running");

    }

    private void Update()
    {
        float distance1 = Vector2.Distance(transform.position, target1.position);
        float distance2 = Vector2.Distance(transform.position, target2.position);
        float distance3 = Vector2.Distance(transform.position, target3.position);
        float distance4 = Vector2.Distance(transform.position, target4.position);

        if ((distance1 <= lookRadius) )//|| (distance2 <= lookRadius) || (distance3 <= lookRadius) || (distance4 <= lookRadius))
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
        playerMovementRIGHT.runSpeed = 0f;
        //Debug.Log("Enemy detected on the left ");
    }
}
*/