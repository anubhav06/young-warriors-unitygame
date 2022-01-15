using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawnRIGHT : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;
    public GameObject playerPrefab4;

    public GameObject playerPrefab5;  //Special character

    public Animator animator1;   //Add Button animator for 1
    public Animator animator2;   //Add Button animator for 2
    public Animator animator3;   //Add Button animator for 3
    public Animator animator4;   //Add Button animator for 4

  //  public Animator animator5;  //Special character


    public Button button;    //For special character(to disable button when pressed)


    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            Spawn1();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            Spawn2();
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            Spawn3();
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            Spawn4();
        }

        if(button.gameObject.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Spawn5();
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

