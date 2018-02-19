using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;

	private void Start ()
    {
        startTime = Time.time;
	}
	
	void Update ()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string secondes = (t % 60).ToString("f2");

        timerText.text = " Vous avez survécu : " + minutes + ":" + secondes;
	}
}
