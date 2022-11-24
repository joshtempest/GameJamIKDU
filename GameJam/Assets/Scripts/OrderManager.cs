using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    List<Order> orders = new List<Order>();
    public TextMeshProUGUI earningsText;
    int earnings;

    private void Start()
    {
        SetEarningsText();
        AddOrder(new Order(10, "Bob"));
    }

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void RemoveOrder(int orderNumber)
    {
        earnings += orders.ElementAt(orderNumber).GetPrice();
        SetEarningsText();
        orders.Remove(orders.ElementAt(orderNumber));
    }

    public void SetEarningsText()
    {
        earningsText.text = "Earnings: " + earnings;
    }
}