using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostManager : MonoBehaviour
{
    public float elecPrice = 1f;
    public float onionPrice = 1f;
    public float tomatoPrice = 1.5f;
    public float saltPrice = 0.5f;
    public float carrotPrice = 1.2f;
    public float finalPrice;
    public float allIngrePrice;

    //magic numbers
    public int day = 3;
    public float Time = 3;

    // Start is called before the first frame update
    void Start()
    {
        elecPrice = elecPrice + ((float)day / 2);
        Debug.LogFormat("Elecprice is: {0}",elecPrice);
        allIngrePrice = (2 * tomatoPrice) + carrotPrice + onionPrice;
        Debug.Log(allIngrePrice);
        finalPrice = (elecPrice * Time) + allIngrePrice;
        Debug.LogFormat("final price for today is {0}", finalPrice);
    }
}
