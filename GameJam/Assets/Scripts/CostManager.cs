using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostManager : MonoBehaviour
{
    //Declares all the variables needed
    public float elecPrice = 1f;
    public float onionPrice = 1f;
    public float tomatoPrice = 1.5f;
    public float saltPrice = 0.5f;
    public float carrotPrice = 1.2f;
    public float finalPrice;
    public float allIngrePrice;

    //Magic numbers, stand-ins from other scripts
    public int day = 3;
    public float Time = 3;
    public int tomatoUsed = 2;
    public int carrotUsed = 1;
    public int onionUsed = 1;
    public int saltUsed = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Calculates the total electricity price for the day
        elecPrice = elecPrice + ((float)day / 2);
        Debug.LogFormat("Elecprice is: {0}",elecPrice);

        //Calculates the price of all ingredients used
        allIngrePrice = ((float)tomatoUsed * tomatoPrice) + ((float)carrotUsed * carrotPrice) + ((float)onionUsed * onionPrice) + ((float)saltUsed * saltPrice);
        Debug.Log(allIngrePrice);

        //Calculates the final price for the day
        finalPrice = (elecPrice * Time) + allIngrePrice;
        Debug.LogFormat("final price for today is {0}", finalPrice);
    }
}
