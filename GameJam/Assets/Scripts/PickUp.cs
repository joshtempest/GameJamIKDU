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
    private GameObject salty;
    private GameObject toma;
    private GameObject carro;
    private float cx;
    private float cy;

    // Start is called before the first frame update
    void Start()
    {
        Fat_Chef = GameObject.Find("Fat_Chef");
        chefTransform = Fat_Chef.GetComponent<Transform>();
        cx = chefTransform.position.x;
        cy= chefTransform.position.y - 10;
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
        Instantiate(tomatoSoup, new Vector3(cx, cy), Quaternion.identity);
    }
    public void destruction()
    {
        salty = GameObject.Find("Salt(Clone)");
        toma = GameObject.Find("Tomato(Clone)");
        carro = GameObject.Find("Carrot(Clone)");
        Destroy(salty);
        Destroy(toma);
        Destroy(carro);
    }
}
