using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    List<Order> orders = new List<Order>();
    public TextMeshProUGUI earningsText;
    int earnings = 0;
    public GameObject moneyCounter;
    MoneyCounter mc;

    private void Start()
    {
        mc = moneyCounter.GetComponent<MoneyCounter>();
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void RemoveOrder(int orderNumber, float timeRemaining)
    {
        earnings = orders.ElementAt(orderNumber).GetPrice() * (int) (1 + timeRemaining/100);
        mc.currentMoney += earnings;
        SetEarningsText();
        orders.Remove(orders.ElementAt(orderNumber));
    }

    public void SetEarningsText()
    {
        earningsText.text = "Earnings: " + earnings;
    }
}