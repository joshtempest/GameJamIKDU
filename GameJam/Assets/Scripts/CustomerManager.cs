using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using TMPro;
using System.Runtime.InteropServices;

public class CustomerManager : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    public GameObject UpgradeController;
    public UpgradeManager upgradeManager;
    private int upgrade;

    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        upgradeManager = UpgradeController.GetComponent<UpgradeManager>();
        upgrade = upgradeManager.pUpgrade;
        timeRemaining += upgrade;
    }    
 

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning == true) 
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                SetTimeText(timeRemaining);
            }
            
            else
            {
                //Debug.Log("Time has run out!");
                print("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;

            if (timeRemaining <= 0)
                {
                print("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                SetTimeText(timeRemaining);
                }
            }
        }
    }

    public void SetTimeText(float time)
    {
        timeText.text = "Time Remaining: " + time.ToString();
    }
}
