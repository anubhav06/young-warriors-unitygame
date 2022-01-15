using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawnBOT : MonoBehaviour {

    public Transform spawnPoint;

    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;
    public GameObject playerPrefab4;

    public GameObject playerPrefab5;  //Special Character


    public Animator animator1;   //Add Button animator for 1
    public Animator animator2;   //Add Button animator for 2
    public Animator animator3;   //Add Button animator for 3
    public Animator animator4;   //Add Button animator for 4

    public Button button;    //For special character(to disable button when pressed)

    public int number;

    private float timeBtwAttack;
    public float startTimeBtwAttack = 0.2f;

    public float startTimeBtwAttackScene = 5f;      //To start spawing after "4" scene starts(S)
    public float startTimeBtwAttackScene2 = 2f;     //To start spawining special character after some time

    public void Update()
    {
        if(startTimeBtwAttackScene <=0 )                //For Starting spawing after 4 sec. of scene load(S)
        {
            if (timeBtwAttack <= 0)                     //To delay the spawn rate by a small amount
            {
                timeBtwAttack = startTimeBtwAttack;
                number = Random.Range(1, 5);   //Generates random no between 1 and 4
            }

            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
        }

        else                                                                  //(S)
        {
            if (startTimeBtwAttackScene >= 0)                          //TO delay the spawn rate
            {
                startTimeBtwAttackScene -= Time.deltaTime;
            }
        }



        if (number==1)             //If 1 then spawn 1........
        {
            Spawn1();
        }
        if (number == 2)
        {
            Spawn2();
        }
        if (number == 3)
        {
            Spawn3();
        }
        if (number == 4)
        {
            Spawn4();
        }

        if (button.gameObject.activeInHierarchy == true)
        {
            if(startTimeBtwAttackScene2<=0)
            {
                Spawn5();
            }
            else
            {
                if(startTimeBtwAttackScene2>=0)
                {
                    startTimeBtwAttackScene2 -= Time.deltaTime;
                }
            }
        }
    }


    public void Spawn1()
    {
        if (animator1.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)  //if its NEW STATE i.e. its not reloading, then we Spawn.
        {
            Instantiate(playerPrefab1, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void Spawn2()
    {
        if (animator2.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {
            Instantiate(playerPrefab2, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void Spawn3()
    {
        if (animator3.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {
            Instantiate(playerPrefab3, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void Spawn4()
    {
        if (animator4.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {
            Instantiate(playerPrefab4, spawnPoint.position, spawnPoint.rotation);
        }
    }

    public void Spawn5()
    {
        Instantiate(playerPrefab5, spawnPoint.position, spawnPoint.rotation);

        button.gameObject.SetActive(false);        //For special character
    }
}
