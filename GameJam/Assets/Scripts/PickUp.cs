using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject tomatoSpawn;
    public GameObject carrotSpawn;
    public GameObject saltSpawn;
    public GameObject tomatoSoup;
    public GameObject Fat_Chef;
    private Transform chefTransform;


    // Start is called before the first frame update
    void Start()
    {
        Fat_Chef = GameObject.Find("Fat_Chef");
        chefTransform = Fat_Chef.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTomato()
    {
        Instantiate(tomatoSpawn, chefTransform, true);
    }
    public void SpawnCarrot()
    {
        Instantiate(carrotSpawn, chefTransform, true);
    }
    public void SpawnSalt()
    {
        Instantiate(saltSpawn, chefTransform, true);
    }
    public void SpawnTomatoSoup()
    {
        Instantiate(tomatoSoup, chefTransform, true);
    }
}
