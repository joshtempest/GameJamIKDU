using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MoneyCounter : MonoBehaviour
{

    public GameObject CostController;
    public CostManager costManager;
    public GameObject TimeController;
    private TimeManager timeManager;
    public GameObject orderManager;
    OrderManager om;

    public float currentMoney = 100f;
    private bool nightTime;
    private float lastPrice;

    public TextMeshProUGUI MoneyText;

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentMoneyText();
        om = orderManager.GetComponent<OrderManager>();
        NoMoney();
        costManager = CostController.GetComponent<CostManager>();
    }

    void Update()
    {
        SetCurrentMoneyText();
    }
    public void NightTimeStuff()
    { 
        costManager.PriceCalculation();
        lastPrice = CostController.GetComponent<CostManager>().finalPrice;
        currentMoney += om.dailyEarnings;
        om.dailyEarnings = 0;
        currentMoney -= lastPrice;
        lastPrice = 0;
    }

    public void SetCurrentMoneyText()
    {
        MoneyText.text = "Money: " + currentMoney;
    }

    public void NoMoney()
    {
        if(currentMoney <= 0 )
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
