using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenPatreon()
	{
#if !UNITY_EDITOR
		openWindow("https://www.patreon.com/anubhav_gupta");
#endif
    }

    public void OpenFeedbackForm()
    {
#if !UNITY_EDITOR
		openWindow("https://forms.gle/XtxMWedvyTZF8rc36");
#endif
    }

    [DllImport("__Internal")]
	private static extern void openWindow(string url);

}