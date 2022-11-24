using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MoneyCounter : MonoBehaviour
{

    public static MoneyCounter instance;
    private CostManager costManager;
    private TimeManager timeManager;

    public TMP_Text moneyText;
    private float currentMoney = 0f;
    private float price;

    // Det er kunderne der skal have den her
    public bool OrderRecieved = false;

    // Start is called before the first frame update
    void Start()
    {
        costManager = GameObject.Find("CostManager").GetComponent<CostManager>();
        timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();
        moneyText.text = "MONEY: " + currentMoney.ToString();
    }


    void FixedUpdate()
    {
        // MIGHT NOT BE NAMED GET NIGHT!!!!
        //if(timeManager.GetNight()){

            //subtract final price
            //Reset finalprce from time manager OR somehow make sure this only subtracts once per night.
            //currentMoney -= finalprice;
            //return currentMoney;



        //}

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
