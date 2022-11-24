using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    // To check if the player has the different ingredients
    public bool hasTomato;
    public bool hasCarrot;
    public bool hasOnion;

    // To check if the player is near the different stations.
    public bool nearTomato, nearCarrot, nearOnion, nearPot = false;

    // To Check if the player has Soup
    public bool hasSoup;

    // To check if the player is within range of the stations
    private bool withinRange;

    private void Update()
    {
        // Makes sures that the player is near a station, and if the key is pressed "gives" the player an ingredient or makes soup
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
    // Is being called in the playerManagement script
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

    // Determines fi the player is near tagged objects
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

    // Determines when the player is no longer near a tagged object
    // If soup has been made - sets the bool to false again
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
