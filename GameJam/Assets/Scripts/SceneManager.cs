using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public float dayLength;
    public static float timer;
    public static int days;
    [SerializeField] bool isCounting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeManager(); // Runs the TimeManager() method every frame.
    }

    public void TimeManager()
    {
        if (isCounting == true) // If isCounting bool is true, the TimeManager function will run.
        {
            timer += Time.deltaTime;
            Debug.Log("Timer = " + timer);

            if (timer >= dayLength)
            {
                days += 1; // Adds a day to the days variable.
                timer = 0; // Resets the timer for he next day.
                Debug.Log("Days = " + days);
            }
        }
        else
        {
            timer = 0; // Resets the timer.
        }
    }
}