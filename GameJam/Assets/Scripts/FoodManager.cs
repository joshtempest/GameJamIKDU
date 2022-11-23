using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public bool hasTomato;
    public bool hasCarrot;
    public bool hasOnion;

    public bool hasSoup;

    private bool withinRange;

    private void FixedUpdate()
    {
        makeSoup();
    }

    private void makeSoup()
    {
        if (hasTomato && hasCarrot && hasOnion && withinRange && Input.GetKeyDown(KeyCode.E))
        {
            hasSoup = true;
            Debug.Log("You made soup. Olga is proud");
        }

        else
        {
            Debug.Log("You have very small PP");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        withinRange = true;
        if (other.gameObject.tag == "Tomatoes")
        {
            hasTomato = true;
            Debug.Log("You have a Tomato");
        }

        else if (other.gameObject.tag == "Carrots")
        {
            hasCarrot = true;
            Debug.Log("You have a carrot");
        }

        else if (other.gameObject.tag == "Onions")
        {
            hasOnion = true;
            Debug.Log("You have a Onion");
        }

        else if (other.gameObject.tag == "Pot")
        {
            hasSoup = true;
            Debug.Log("gut soup");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (hasSoup)
        {
            hasTomato = false;
            hasCarrot = false;
            hasOnion = false;
            Debug.Log("No more ingredients");
        }
    }
}
