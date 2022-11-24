using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MoneyCounter : MonoBehaviour
{

    public static MoneyCounter instance;
    //private CostManager costManager;
    //private TimeManager timeManager;
    public GameObject CostController;
    public GameObject TimeController;

    public TMP_Text moneyText;
    private float currentMoney = 3f;
    private float price;
    private bool nightTime;
    private float lastPrice;

    // Det er kunderne der skal have den her
    //public bool OrderRecieved = false;

    // Start is called before the first frame update
    void Start()
    {
        //costManager = CostController.GetComponent<CostManager>().finalPrice;
        //timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();

        
        //moneyText.text = "MONEY: " + currentMoney.ToString();

    }

    void FixedUpdate()
    {
        lastPrice = CostController.GetComponent<CostManager>().finalPrice;
        nightTime = TimeController.GetComponent<TimeManager>().isNight;
        // MIGHT NOT BE NAMED GET NIGHT!!!!
        if(nightTime == true)
        {
            //subtract final price
            //Reset finalprce from time manager OR somehow make sure this only subtracts once per night.
            currentMoney -= lastPrice;
            lastPrice = 0;
        }
        else
        {
            currentMoney = currentMoney;
        }

    /*
    public void addMoney()
    {
        currentMoney += 5;
    }

    public void takeMoney()
    {
        currentMoney -= price;
    }

    public float getPrice(){
        return price;
    }

    public void setPrice(value)
    */

    // Update is called once per frame
    void Update()
    {
        
    }

    }

}
