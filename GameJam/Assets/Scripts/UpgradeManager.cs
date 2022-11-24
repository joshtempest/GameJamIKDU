using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class UpgradeManager : MonoBehaviour
{

    public int pUpgrade;
    public int tUpgrade;

    public GameObject MoneyController;
    
    private MoneyCounter moneycounter;

    void Start()
    {
        moneycounter = MoneyController.GetComponent<MoneyCounter>();
        
    }

//This function is inwoked by pressing the button
    public void CustomerPatience()

    {
        pUpgrade += 2;
        moneycounter.currentMoney -= 20;

    }

    public void Tips()

    {
        tUpgrade += 2;
        moneycounter.currentMoney -= 25;
    }

     public void AntiDepressants()

    {
        
    }


}


      

