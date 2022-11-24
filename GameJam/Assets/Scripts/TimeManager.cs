using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float dayLength;
    [HideInInspector] public float timer;
    [HideInInspector] public int days = 1;
    [HideInInspector] public bool isNight;
    public bool isCounting;

    // Gets all scripts needed.
    public GameObject SceneController;
    private SceneManager sceneManager;

    // When true enables console debugging.
    [SerializeField] private bool enableDebugging;

    // Start is called before the first frame update
    void Start()
    {
        isNight = false;

        sceneManager = SceneController.GetComponent<SceneManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeCounter(); // Runs the TimeManager() method every frame.
    }

    public void TimeCounter()
    {
        if (isCounting == true) // If isCounting bool is true, the TimeManager function will run.
        {
            // Disables the night.
            isNight = false;
            Debugger("isNotNight");

            timer += Time.deltaTime;
            //Debug.Log("Timer = " + timer);

            if (timer >= dayLength)
            {
                days += 1; // Adds a day to the days variable.
                timer = 0; // Resets the timer for he next day.
                
                Debugger("Days");
                Debugger("isNight");

                sceneManager.UpgradeMenu();


                isNight = true;
                isCounting = false;
            }
        }
        else
        {
            timer = 0; // Resets the timer.
        }
    }
    void Debugger(string type)
    {
        if (enableDebugging == true)
        {
            if (type == "Days")
            {
                Debug.Log("Days = " + days);
            }
            if (type == "isNight")
            {
                Debug.Log("It is now night.");
            }
            if (type == "isNotNight")
            {
                Debug.Log("It is now night.");
            }
        }
    }
}