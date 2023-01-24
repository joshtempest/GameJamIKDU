using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is used for controlling the spawning and destruction of objects that are picked up in the game. Allowing for the dynamic addition and removal of objects in the scene. 
/// </summary>
public class PickUp : MonoBehaviour
{
    // These lines declare public GameObject variables that are used to reference different prefabs in the game.
    public GameObject tomatoSpawn;
    public GameObject carrotSpawn;
    public GameObject saltSpawn;
    public GameObject tomatoSoup;
    public GameObject Fat_Chef;

    // These lines declare private Transform and GameObject variables that are used to store references to specific instances of objects in the game.
    private Transform chefTransform;
    private GameObject salty;
    private GameObject toma;
    private GameObject carro;

    // Declares a private float variable that is used to store the x-coordinate of the chef's position.
    private float cx;

    // Declares a private float variable that is used to store the y-coordinate of the chef's position.
    private float cy;

    // The Start method is called before the first frame update, it's used to initialize variables or states before the game starts.
    void Start()
    {
        Fat_Chef = GameObject.Find("Fat_Chef"); // Assigns the "Fat_Chef" object to the "Fat_Chef" variable.
        chefTransform = Fat_Chef.GetComponent<Transform>(); // Assigns the Transform component of the "Fat_Chef" object to the "chefTransform" variable.
        cx = chefTransform.position.x + 12.861f; // Assigns the x-coordinate of the chef's position plus 12.861f to the "cx" variable.
        cy = chefTransform.position.y + 5.1f; // Assigns the y-coordinate of the chef's position plus 5.1f to the "cy" variable.
    }

    // The SpawnTomato method is used to instantiate a new "tomatoSpawn" object as a child of the "chefTransform" object.
    public void SpawnTomato()
    {
        Instantiate(tomatoSpawn, chefTransform, true);
    }

    // The SpawnCarrot method is used to instantiate a new "carrotSpawn" object as a child of the "chefTransform" object.
    public void SpawnCarrot()
    {
        Instantiate(carrotSpawn, chefTransform, true);
    }

    // The SpawnSalt method is used to instantiate a new "saltSpawn" object as a child of the "chefTransform" object.
    public void SpawnSalt()
    {
        Instantiate(saltSpawn, chefTransform, true);
    }

    // The SpawnTomatoSoup method is used to instantiate a new "tomatoSoup" object as a child of the "chefTransform" object.
    public void SpawnTomatoSoup()
    {
        Instantiate(tomatoSoup, chefTransform, true);
    }
    
    // The destruction method is used to find and destroy the "Salt(Clone)", "Tomato(Clone)" and "Carrot(Clone)" objects.
    public void destruction()
    {
        salty = GameObject.Find("Salt(Clone)"); // Finds the "Salt(Clone)" GameObject.
        toma = GameObject.Find("Tomato(Clone)"); // Finds the "Tomato(Clone)" GameObject.
        carro = GameObject.Find("Carrot(Clone)"); // Finds the "Carrot(Clone)" GameObject.
        Destroy(salty); // Destroys the "salty" GameObject.
        Destroy(toma); // Destroys the "toma" GameObject.
        Destroy(carro); // Destroys the "carro" GameObject.
    }
}
