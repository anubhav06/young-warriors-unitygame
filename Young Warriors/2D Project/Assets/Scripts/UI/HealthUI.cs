using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthUI : MonoBehaviour {

    public float health;
    public Image healthImage;

    public GameObject gameMenu;
    public GameObject gameOverMenu;
    public GameObject arrowLeft;
    public GameObject arrowRight;

    public TextMeshProUGUI text;
    public TextMeshProUGUI timeText;
    public GameObject timeObject;

    public ParticleSystem particleEffect;

    private bool temp = true;

    private void Update()
    {
        healthImage.fillAmount = (health / 100);

        if(health <= 0f || health>=100f)      //If Health is below 0 or above 100 we say game is over
        {
            if(temp==true)
            {
                GameOver();
            }

        }
    }

    void GameOver()
    {
       // Debug.Log("Game Over !!");
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);

        arrowLeft.SetActive(false);//Disables the arrow
        arrowRight.SetActive(false);

        if(health>=100f)
        {
            if (SceneManager.GetActiveScene().name == "Game 1")     //Checks the cuurent scene name. Used to check if the scene is of BOT or not
            {
                timeObject.SetActive(true);

                timeText.text = "Time taken:  " + (System.Math.Round((GameObject.Find("Main Camera").GetComponent<Timer>().time / 60) , 2 )).ToString() + " min.";  
                text.text = "You WIN !!";
            }
            else if (SceneManager.GetActiveScene().name == "Game")
            {
                timeObject.SetActive(true);
                text.text = "Player 1 WINS !!";
            }
        }

        else if(health<=0f)
        {
            if (SceneManager.GetActiveScene().name == "Game 1")     //Checks the cuurent scene name. Used to check if the scene is of BOT or not
            {
                timeObject.SetActive(false);
                text.text = "You LOOSE !!";
            }
            else if (SceneManager.GetActiveScene().name == "Game")
            {
                timeObject.SetActive(false);
                text.text = "Player 2 WINS !!";
            }
        }

        //timeText.text = "Time taken:  " + (GameObject.Find("Main Camera").GetComponent<Timer>().time / 60).ToString() + "minutes";

        particleEffect.Emit(1);

        temp = false;
    }
}
