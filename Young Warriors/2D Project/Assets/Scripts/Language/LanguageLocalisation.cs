using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageLocalisation : MonoBehaviour {


    public static LanguageLocalisation singelton = null;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(singelton==null)
        {
            singelton = this;
        }
    }
}
