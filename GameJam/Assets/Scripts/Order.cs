using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{
    int price;
    string customerName;

    public Order(int price, string customerName)
    {
        this.price = price;
        this.customerName = customerName;
    }

    public int GetPrice()
    {
        return price;
    }

    public string GetCustomerName()
    {
        return customerName;
    }
}