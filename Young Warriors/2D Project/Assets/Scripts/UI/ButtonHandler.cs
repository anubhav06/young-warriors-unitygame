using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonHandler : MonoBehaviour
{
    public Button yourButton;
    public bool buttonClick = false;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Pressed");
        buttonClick = true;
    }
}
