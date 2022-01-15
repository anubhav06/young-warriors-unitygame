using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerRIGHT : MonoBehaviour
{

    #region Singleton

    public static PlayerManagerRIGHT instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion
    
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject player5;     //Special Player(Charge)

}
