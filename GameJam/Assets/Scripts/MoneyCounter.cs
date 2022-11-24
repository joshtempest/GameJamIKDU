using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MoneyCounter : MonoBehaviour
{

    public GameObject CostController;
    public GameObject TimeController;
    private TimeManager timeManager;

    private float currentMoney = 3f;
    private bool nightTime;
    private float lastPrice;


    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        timeManager = TimeController.GetComponent<TimeManager>();
        
        lastPrice = CostController.GetComponent<CostManager>().finalPrice;
        nightTime = timeManager.isNight;
    
        if(nightTime == true)
        {
            currentMoney -= lastPrice;
            lastPrice = 0;
        }
        else
        {
            
        }

    }

}
