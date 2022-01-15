using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    
    public int health;
    public bool life = true;

    float horizontalMove = 1f;
    public float runSpeed; 

    public float temprunSpeed; // Created a temp variable which is accessed within the script so that runSpeed can be changed from outside. Was not working with "runSpeed" ALONE. Basically just set "runSpeed" to the required Run Speed in the game outside the scipt.
    public float initialRunSpeed;//Just declared to get the initial spped and then access from archer collision left

    private float dazedTime;
    public float startDazedTime;

    public ChargeUIRIGHT chargeUI;        //For charge bar

    private void Start()
    {
        animator = GetComponent<Animator>();
        initialRunSpeed = runSpeed;

        chargeUI = GameObject.Find("Main Camera").GetComponent<ChargeUIRIGHT>();       //Find the Charge UI script for charginf bar
    }

    private void Update()
    {
        if (dazedTime <= 0)
        {
            // runSpeed = 3f;
            temprunSpeed = runSpeed;
        }
        else
        {
            //runSpeed = 0f;
            temprunSpeed = 0f;
            dazedTime -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            life = false;
        }

        animator.SetFloat("Speed", temprunSpeed);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * temprunSpeed * Time.fixedDeltaTime, false, false);
    }

    public void TakeDamage(int damage)//combat
    {
        dazedTime = startDazedTime;
        health -= damage;

        chargeUI.totalDamgeCharge += damage;
    }
}