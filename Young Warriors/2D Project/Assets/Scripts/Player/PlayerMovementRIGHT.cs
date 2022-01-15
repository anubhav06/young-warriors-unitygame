using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRIGHT : MonoBehaviour
{

    public CharacterController2D controller;

    public Animator animator;

    //public Health Health;
    public int health;
    public bool life = true;

    float horizontalMove = -1f;
    public float runSpeed;  //Just change the runSpeed in player prefab because changes made here arent reflected there

    public float temprunSpeed;
    public float initialRunSpeed;//Just declared to get the initial spped and then access from archer collision left

    private float dazedTime;
    public float startDazedTime;

    public ChargeUI chargeUI;

    private void Start()
    {
        animator = GetComponent<Animator>();
        initialRunSpeed = runSpeed;

        chargeUI = GameObject.Find("Main Camera").GetComponent<ChargeUI>();       //Find the Charge UI script for charginf bar

    }

    private void Update()
    {
        if (dazedTime <= 0)
        {
            temprunSpeed = runSpeed;
        }
        else
        {
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
