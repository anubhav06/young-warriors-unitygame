using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {


    public Rigidbody2D rb;
    public float lifeTIme;


    public float speedX = 5.48f;
    public float speedY = 0f;

    public int arrowDamage = 2;

    private void Start()
    {
         Invoke("DestroyProjectile", lifeTIme);
    }

    // Update is called once per frame
    void Update () {

        rb.velocity = new Vector2(speedX, speedY);
        //transform.Translate(-transform.forward * speed * Time.deltaTime);                  //-transform.up
    }

    void DestroyProjectile()
    {
                                                                                         //Can add particle effect of death also  here
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemyRight")
        {
            collision.gameObject.GetComponent<PlayerMovementRIGHT>().health -= arrowDamage;
            Destroy(gameObject);
        }
    }

}