using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float time = 0f;
    public float timeLimit;
    public Image chargeImage;

    public GameObject gameMenu;
    public GameObject gameOverMenu;
    public GameObject arrowLeft;
    public GameObject arrowRight;

    public TextMeshProUGUI text;

    public ParticleSystem particleEffect;

    private void Update()
    {
        if (time <= timeLimit)       //TimeLimit i.e. 4 min is the time limit
        {
            time += 1 * Time.deltaTime;
        }


        chargeImage.fillAmount = (time / timeLimit);

        if (chargeImage.fillAmount == 1)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);

        arrowLeft.SetActive(false);//Disables the arrow
        arrowRight.SetActive(false);

        if (GameObject.Find("Main Camera").GetComponent<HealthUI>().health < 50f)
        {
            if(SceneManager.GetActiveScene().name == "Game 1")     //Checks the cuurent scene name. Used to check if the scene is of BOT or not
            {
                text.text = "You LOOSE !!";
            }
            else if (SceneManager.GetActiveScene().name == "Game")     
            {
                text.text = "Player 2 WINS !!";
            }
        }

        else if (GameObject.Find("Main Camera").GetComponent<HealthUI>().health >= 50f)
        {
            if (SceneManager.GetActiveScene().name == "Game 1")     //Checks the cuurent scene name. Used to check if the scene is of BOT or not
            {
                text.text = "You WIN !!";
            }
            else if(SceneManager.GetActiveScene().name == "Game")
            {
                text.text = "Player 1 WINS !!";
            }
        }

        particleEffect.Emit(1);
    }
}