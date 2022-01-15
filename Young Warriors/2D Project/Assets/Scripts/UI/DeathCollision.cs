using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour {

    public HealthUI healthUI;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Right_1(Clone)" || collision.gameObject.name == "Right_2(Clone)" || collision.gameObject.name == "Right_3(Clone)" || collision.gameObject.name == "Right_4(Clone)" || collision.gameObject.name == "Special_2(Clone)")
        {                                                         //Checks if any of the above right 1,2,3,4 collides, If yes then:
            Destroy(collision.gameObject);
            healthUI.health -= 5; //Subtracts 5 Health i.e. Shifts the bar to the left
        }
    }

}
