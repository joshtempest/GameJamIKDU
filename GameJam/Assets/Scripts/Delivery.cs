using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public GameObject orderManager;
    OrderManager om;
    public GameObject player;
    FoodManager fm;
    public GameObject customer;
    CustomerManager cm;

    private void Start()
    {
        om = orderManager.GetComponent<OrderManager>();
        fm = player.GetComponent<FoodManager>();
        cm = customer.GetComponent<CustomerManager>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Q) && fm.hasSoup)
        {
            Debug.Log("Delivery");
            cm.timerIsRunning = false;
            fm.hasSoup = false;
            om.RemoveOrder(0);
        }
    }
}
