using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeUIRIGHT : MonoBehaviour {

    public Image chargeImage;
    public float totalDamgeCharge = 0;

    public Button button;

    private void Update()
    {
        chargeImage.fillAmount = (totalDamgeCharge / 2000);

        if (chargeImage.fillAmount == 1)
        {
            Charged();
        }
    }


    void Charged()
    {
        totalDamgeCharge = 0;           //Damge resets to 0 / basically charge goes to 0
        button.gameObject.SetActive(true);

    }
}
