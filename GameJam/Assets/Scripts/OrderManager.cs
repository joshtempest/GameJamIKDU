using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    List<Order> orders = new List<Order>();
    int earnings = 0;
    public GameObject moneyCounter;
    MoneyCounter mc;
    public GameObject upgradeController;
    UpgradeManager um;
    public float dailyEarnings = 0;

    private void Start()
    {
        mc = moneyCounter.GetComponent<MoneyCounter>();
        um = upgradeController.GetComponent<UpgradeManager>();
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void RemoveOrder(int orderNumber, float timeRemaining)
    {
        try
        {
            earnings = orders.ElementAt(orderNumber).GetPrice() + um.tUpgrade;
        }
        catch (ArgumentOutOfRangeException)
        {
            Debug.Log("No Orders!");
        }        
        dailyEarnings += earnings;
        orders.Remove(orders.ElementAt(orderNumber));
    }
}