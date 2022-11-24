using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public bool hasTomato;
    public bool hasCarrot;
    public bool hasOnion;

    public bool nearTomato, nearCarrot, nearOnion, nearPot = false;


    public bool hasSoup;

    private bool withinRange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (nearOnion) hasOnion = true;

            else if (nearTomato) hasTomato = true;

            else if (nearCarrot) hasCarrot = true;

            else if (nearPot && hasTomato && hasOnion && hasCarrot)
            {
                hasSoup = true;
                Debug.Log("You made soup. Olga is proud");
            }

        }

    }
    public void Actions()
    {
        if (nearOnion) hasOnion = true;
        else if (nearTomato) hasTomato = true;
        else if (nearCarrot) hasCarrot = true;
        else if (nearPot && hasTomato && hasOnion && hasCarrot)
        {
            hasSoup = true;
            Debug.Log("You made soup. Olga is proud");
        }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        withinRange = true;
        if (collision.gameObject.tag == "Tomatoes")
        {
            nearTomato = true;
        }

        else if (collision.gameObject.tag == "Carrots")
        {
            nearCarrot = true;
        }

        else if (collision.gameObject.tag == "Onions")
        {
            nearOnion = true;
            //hasOnion = true;
        }

        else if (collision.gameObject.tag == "Pot")
        {
            nearPot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        nearOnion = false;
        nearCarrot = false;
        nearTomato = false;
        nearPot = false;

        if (hasSoup)
        {
            hasTomato = false;
            hasCarrot = false;
            hasOnion = false;
            Debug.Log("No more ingredients");
        }
    }
}
