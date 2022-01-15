using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollisionRIGHT : MonoBehaviour {

    public HealthUI healthUI;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "1(Clone)" || collision.gameObject.name == "2(Clone)" || collision.gameObject.name == "3(Clone)" || collision.gameObject.name == "4(Clone)" || collision.gameObject.name == "Special_4(Clone)")
        {                                                         //Checks if any of the above right 1,2,3,4 collides, If yes then:
            Destroy(collision.gameObject);
            healthUI.health += 5; //Adds 5 Health i.e. Shifts the bar to the right
        }
    }
}
