using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public float timeRemaining;

    public bool timerIsRunning = false;

    public Text timeText;

    int minutes;

    int seconds;

    bool isZero;

    int timeRemaining1;

    float deltaTime = 0.0f;

    string text;

    private void Start()
    {
        // Starts the timer automatically
        timeRemaining = 300.0f;
        timerIsRunning = true;

       
        Screen.SetResolution( 1008 , 1120, true);
    }

    	void OnGUI()
	{

		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
        text = fps.ToString("0");
		//text = string.Format("{0:0.0} ms ({1:0.} fps)", msec,  fps);
	}

    void Update()
    {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;



                gameObject.GetComponent<TextMesh>().text =  text;
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "rightController")
        {
        }
    }
}
