using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnClick : MonoBehaviour {

    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;

    //*********************************************************  If we click Buuton 1 :  ************************************************************

    public void ButtonClick1()
    {

        if (anim1.GetCurrentAnimatorStateInfo(0).IsTag("0") == true) //Checks if button one is reloading or not. Here its 0 so its not reloading.
        {
            //Checks if "Other buttons" of "Respective animation " are running.If yes then....Rewinds the animation back to start

            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("left_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim2.Play("left_btn2", -1, 0f);
            }

            if (anim3.GetCurrentAnimatorStateInfo(0).IsName("left_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim3.Play("left_btn3", -1, 0f);
            }

            if (anim4.GetCurrentAnimatorStateInfo(0).IsName("left_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
            {
                anim4.Play("left_btn4", -1, 0f);  //Rewinds the animation back to start
            }


            //Plays i.e. reloads all buttons on click:

            anim1.Play("left_btn1");
            anim2.Play("left_btn2");
            anim3.Play("left_btn3");
            anim4.Play("left_btn4");


        }
     
       
    }

    
    //*********************************************************  If we click Buuton 2 :  ************************************************************


    public void ButtonClick2()
    {

        if (anim2.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {


            if (anim1.GetCurrentAnimatorStateInfo(0).IsName("left_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim1.Play("left_btn1", -1, 0f);
            }

            if (anim3.GetCurrentAnimatorStateInfo(0).IsName("left_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim3.Play("left_btn3", -1, 0f);
            }

            if (anim4.GetCurrentAnimatorStateInfo(0).IsName("left_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
            {
                anim4.Play("left_btn4", -1, 0f);  //Rewinds the animation back to start
            }


            anim1.Play("left_btn1");
            anim2.Play("left_btn2");
            anim3.Play("left_btn3");
            anim4.Play("left_btn4");

        }


    }


    //*********************************************************  If we click Buuton 3 :  ************************************************************


    public void ButtonClick3()
    {

        if (anim3.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {


            if (anim1.GetCurrentAnimatorStateInfo(0).IsName("left_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim1.Play("left_btn1", -1, 0f);
            }

            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("left_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim2.Play("left_btn2", -1, 0f);
            }

            if (anim4.GetCurrentAnimatorStateInfo(0).IsName("left_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
            {
                anim4.Play("left_btn4", -1, 0f);  //Rewinds the animation back to start
            }


            anim1.Play("left_btn1");
            anim2.Play("left_btn2");
            anim3.Play("left_btn3");
            anim4.Play("left_btn4");

        }


    }


    //*********************************************************  If we click Buuton 4 :  ************************************************************


    public void ButtonClick4()
    {

        if (anim4.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
        {


            if (anim1.GetCurrentAnimatorStateInfo(0).IsName("left_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim1.Play("left_btn1", -1, 0f);
            }

            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("left_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                anim2.Play("left_btn2", -1, 0f);
            }

            if (anim3.GetCurrentAnimatorStateInfo(0).IsName("left_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
            {
                anim3.Play("left_btn3", -1, 0f);  //Rewinds the animation back to start
            }


            anim1.Play("left_btn1");
            anim2.Play("left_btn2");
            anim3.Play("left_btn3");
            anim4.Play("left_btn4");

        }


    }
}
