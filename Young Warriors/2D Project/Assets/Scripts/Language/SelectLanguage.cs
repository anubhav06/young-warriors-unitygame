using UnityEngine.UI;
using UnityEngine;

public class SelectLanguage : MonoBehaviour {

    public bool english = false;
    public bool german = false;
    public bool french = false;
    public bool spanish = false;
    public bool russian = false;

    public Sprite flagEnglish;
    public Sprite flagGerman;
    public Sprite flagFrench;
    public Sprite flagSpanish;
    public Sprite flagRussian;

    public GameObject currentFlag;

    public void FlagChange()
    {
        if(currentFlag.gameObject.GetComponent<Image>().sprite == flagEnglish)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagGerman;

            english = false;
            german = true;
            french = false;
            spanish = false;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagGerman)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagFrench;

            english = false;
            german = false;
            french = true;
            spanish = false;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagFrench)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagSpanish;

            english = false;
            german = false;
            french = false;
            spanish = true;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagSpanish)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagRussian;

            english = false;
            german = false;
            french = false;
            spanish = false;
            russian = true;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagRussian)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagEnglish;

            english = true;
            german = false;
            french = false;
            spanish = false;
            russian = false;
        }

    }

    public void PreviousFlagChange()
    {
        if (currentFlag.gameObject.GetComponent<Image>().sprite == flagEnglish)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagRussian;

            english = false;
            german = false;
            french = false;
            spanish = false;
            russian = true;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagRussian)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagSpanish;

            english = false;
            german = false;
            french = false;
            spanish = true;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagSpanish)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagFrench;

            english = false;
            german = false;
            french = true;
            spanish = false;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagFrench)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagGerman;

            english = false;
            german = true;
            french = false;
            spanish = false;
            russian = false;
        }

        else if (currentFlag.gameObject.GetComponent<Image>().sprite == flagGerman)
        {
            currentFlag.gameObject.GetComponent<Image>().sprite = flagEnglish;

            english = true;
            german = false;
            french = false;
            spanish = false;
            russian = false;
        }

    }
}
