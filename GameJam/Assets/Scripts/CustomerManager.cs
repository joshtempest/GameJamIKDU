using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class CustomerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;

    }
}

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
            }
            else
            {
            Debug.Log("Time has run out!");
            timeRemaining = 0;
            timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
    TimeSpan remaining = TimeSpan.FromSeconds(timeToDisplay);
    timeText.text = remaining.ToString(@”hh\:mm\:ss”);
    }
    }
