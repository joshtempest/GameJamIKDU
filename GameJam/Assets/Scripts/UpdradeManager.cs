using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class UpdradeManager : MonoBehaviour
{

    //public gameObject OrderPickup;
    public int currentMoney;
    public string labelText = "Money";
    public TMP_Text moneyText;
    public int value;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate ()
    {
        //if (OrderPickup = (true))
        {
            //currentMoney =+ 1;
            //Debug.Log("You now have" + currentMoney);
        }
           
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        //if(OrderPickup != null)
        {
            //currentMoney +1;
            //MoneyCounter.instance.increaseMmoney(value);
        }

    }

    void OnGUI()
    {
        GUI.Box (new Rect(20, 20, 150, 25), "Money" + currentMoney);
        }
}


      

