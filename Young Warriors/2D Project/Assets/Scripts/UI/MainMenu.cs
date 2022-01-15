using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void LoadLevel1()
    {
        SceneManager.LoadScene(1);   //Gets the current scene index and increses it by 1, So we go to the next level
    }


    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);   
    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
