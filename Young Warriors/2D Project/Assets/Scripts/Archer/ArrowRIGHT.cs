using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRIGHT : MonoBehaviour {

    public Rigidbody2D rb;
    public float lifeTIme;


    public float speedX = 5.48f;
    public float speedY = 0f;

    public int arrowDamage = 2;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTIme);
    }

    void Update()
    {
        rb.velocity = new Vector2(speedX, speedY);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyLeft")
        {
            collision.gameObject.GetComponent<PlayerMovement>().health -= arrowDamage;
            Destroy(gameObject);
        }
    }

}
