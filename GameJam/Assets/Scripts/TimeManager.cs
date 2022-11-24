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

    // Start is called before the first frame update
    void Start()
    {
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
            timer += Time.deltaTime;
            //Debug.Log("Timer = " + timer);

            if (timer >= dayLength)
            {
                days += 1; // Adds a day to the days variable.
                timer = 0; // Resets the timer for he next day.
                Debug.Log("Days = " + days);

                if (isNight == true)
                {
                    isNight = false;
                    Debug.Log("Night = " + isNight);
                }
                if (isNight == false)
                {
                    isNight = true;
                    Debug.Log("Night = " + isNight);
                }
            }
        }
        else
        {
            timer = 0; // Resets the timer.
        }
    }
}