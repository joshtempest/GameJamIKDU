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
    private float cx;
    private float cy;

    // Start is called before the first frame update
    void Start()
    {
        Fat_Chef = GameObject.Find("Fat_Chef");
        chefTransform = Fat_Chef.GetComponent<Transform>();
        cx = chefTransform.position.x;
        cy= chefTransform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTomato()
    {
        Instantiate(tomatoSpawn, new Vector2(cx,cy), Quaternion.identity);
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
