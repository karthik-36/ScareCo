using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
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
    }

    	void OnGUI()
	{

		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
	}

    void Update()
    {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timeRemaining1 = (int) timeRemaining;
            minutes = (timeRemaining1 / 60);
            seconds = (timeRemaining1 % 60);

            //(seconds.ToString("0").Length == 2) ? seconds.ToString("0") : "0" + seconds.ToString("0")

            if (seconds.ToString("0").Length == 2)
            {
                gameObject.GetComponent<TextMesh>().text =
                    minutes.ToString("0") + ":" + seconds.ToString("0");
            }
            else
            {
                gameObject.GetComponent<TextMesh>().text =
                    minutes.ToString("0") + ":0" + seconds.ToString("0");
            }
            // gameObject.GetComponent<TextMesh>().text = timeRemaining.ToString("0");
            // if (timerIsRunning)
            // {
            //     if (timeRemaining > 0)
            //     {
            //         timeRemaining -= Time.deltaTime;
            //         DisplayTime(timeRemaining);
            //     }
            //     else
            //     {
            //         Debug.Log("Time has run out!");
            //         timeRemaining = 0;
            //         timerIsRunning = false;
            //     }
            // }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "rightController")
        {
        }
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Timer : MonoBehaviour
// {
//     public float timeRemaining = 5;
//     public bool timerIsRunning = false;

//     private void Start()
//     {
//         // Starts the timer automatically
//         timerIsRunning = true;
//     }

//     void Update()
//     {
//         if (timerIsRunning)
//         {
//             if (timeRemaining > 0)
//             {
//                 timeRemaining -= Time.deltaTime;
//                  gameObject.GetComponent<TextMesh>().text = timeRemaining.ToString();
//             }
//             else
//             {
//                 Debug.Log("Time has run out!");
//                 timeRemaining = 0;
//                 timerIsRunning = false;
//             }
//         }
//     }
// }
