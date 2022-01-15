using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBOT : MonoBehaviour {

    int index = 0;
    public int totalLevels = 2;
    public float yOffset = 1f;

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    private int pos;   //Used  instead of asking input from user

    void Update()
    {
        if(timeBtwAttack<=0)
        {
            timeBtwAttack = startTimeBtwAttack;

            pos = Random.Range(1, 3);    //Genereates 1 or 2, instead for inputting down or up arrow
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }

        
        if (pos==2)                  //iF its 2(Up arrow):
        {
            if (index <= totalLevels - 1)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;
            }
        }

        if (pos == 1)                //iF its 1(Down arrow)
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }
    }
}
