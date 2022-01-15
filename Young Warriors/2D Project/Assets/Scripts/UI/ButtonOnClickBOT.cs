using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOnClickBOT : MonoBehaviour {


    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;


    //*********************************************************  If we press 1 :  ************************************************************
    public void Update()
    {
        //This is unlike ButtonOnClick where we check for mouse click, here we specifically check the desired key pressed by the below is statement.

        if (GameObject.Find("Main Camera").GetComponent<PlayerSpawnBOT>().number == 1)  //Checks if we press 1,  then :-
        {
            if (anim1.GetCurrentAnimatorStateInfo(0).IsTag("0") == true) //Checks if button one is reloading or not. Here its 0 so its not reloading.
            {
                //Checks if "Other buttons" of "Respective animation " are running.If yes then....Rewinds the animation back to start

                if (anim2.GetCurrentAnimatorStateInfo(0).IsName("right_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim2.Play("right_btn2", -1, 0f);
                }

                if (anim3.GetCurrentAnimatorStateInfo(0).IsName("right_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim3.Play("right_btn3", -1, 0f);
                }

                if (anim4.GetCurrentAnimatorStateInfo(0).IsName("right_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
                {
                    anim4.Play("right_btn4", -1, 0f);  //Rewinds the animation back to start
                }

                //Plays i.e. reloads all buttons on click:

                anim1.Play("right_btn1");
                anim2.Play("right_btn2");
                anim3.Play("right_btn3");
                anim4.Play("right_btn4");
            }
        }

        //*********************************************************  If we press 2 :  ************************************************************


        if (GameObject.Find("Main Camera").GetComponent<PlayerSpawnBOT>().number == 2)  //Checks if we press 2,  then :-
        {

            if (anim2.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
            {


                if (anim1.GetCurrentAnimatorStateInfo(0).IsName("right_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim1.Play("right_btn1", -1, 0f);
                }

                if (anim3.GetCurrentAnimatorStateInfo(0).IsName("right_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim3.Play("right_btn3", -1, 0f);
                }

                if (anim4.GetCurrentAnimatorStateInfo(0).IsName("right_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
                {
                    anim4.Play("right_btn4", -1, 0f);  //Rewinds the animation back to start
                }


                anim1.Play("right_btn1");
                anim2.Play("right_btn2");
                anim3.Play("right_btn3");
                anim4.Play("right_btn4");

            }


        }


        //*********************************************************  If we press 3 :  ************************************************************


        if (GameObject.Find("Main Camera").GetComponent<PlayerSpawnBOT>().number == 3)  //Checks if we press 3,  then :-
        {

            if (anim3.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
            {


                if (anim1.GetCurrentAnimatorStateInfo(0).IsName("right_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim1.Play("right_btn1", -1, 0f);
                }

                if (anim2.GetCurrentAnimatorStateInfo(0).IsName("right_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim2.Play("right_btn2", -1, 0f);
                }

                if (anim4.GetCurrentAnimatorStateInfo(0).IsName("right_btn4") && anim4.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
                {
                    anim4.Play("right_btn4", -1, 0f);  //Rewinds the animation back to start
                }


                anim1.Play("right_btn1");
                anim2.Play("right_btn2");
                anim3.Play("right_btn3");
                anim4.Play("right_btn4");

            }


        }


        //*********************************************************  If we press 4 :  ************************************************************


        if (GameObject.Find("Main Camera").GetComponent<PlayerSpawnBOT>().number == 4)  //Checks if we press 4,  then :-
        {

            if (anim4.GetCurrentAnimatorStateInfo(0).IsTag("0") == true)
            {


                if (anim1.GetCurrentAnimatorStateInfo(0).IsName("right_btn1") && anim1.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim1.Play("right_btn1", -1, 0f);
                }

                if (anim2.GetCurrentAnimatorStateInfo(0).IsName("right_btn2") && anim2.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
                {
                    anim2.Play("right_btn2", -1, 0f);
                }

                if (anim3.GetCurrentAnimatorStateInfo(0).IsName("right_btn3") && anim3.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f) //Checks if "left_btn4" of anim4 is running. If yes then....
                {
                    anim3.Play("right_btn3", -1, 0f);  //Rewinds the animation back to start
                }


                anim1.Play("right_btn1");
                anim2.Play("right_btn2");
                anim3.Play("right_btn3");
                anim4.Play("right_btn4");

            }


        }
    }

}
