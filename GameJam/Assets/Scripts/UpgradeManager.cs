using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

/// <summary>
/// This script allows the player to upgrade two things, customer patience and tips. The player can upgrade these things by pressing buttons and cost a certain amount of money. It also keeps track of the player's money.
/// </summary>
public class UpgradeManager : MonoBehaviour
{
    public int pUpgrade; //Intiger variable that holds the upgrade level of the patience.
    public int tUpgrade; //Intiger variable that holds the upgrade level of the tips.

    public GameObject MoneyController; //Declares a public GameObject variable called MoneyController.

    private MoneyCounter moneycounter; //Declares a private variable of type MoneyCounter called moneycounter.

    //This function is called when the script is first loaded or enabled.
    void Start()
    {
        moneycounter = MoneyController.GetComponent<MoneyCounter>(); //Sets the moneycounter variable to the MoneyCounter component on the MoneyController GameObject
    }

    /// <summary>
    /// This method allows the player to upgrade the customer patience. It is inwoked by pressing a button.
    /// </summary>
    public void CustomerPatience()

    {
        if (moneycounter.currentMoney - 20 < 0) return; //Checks if the current money is less than 20, if so return nothing.
        pUpgrade += 2; //Increments the pUpgrade by 2.
        moneycounter.currentMoney -= 20; //Decrements the current money by 20.
    }

    /// <summary>
    /// This method allows the player to upgrade the tips. It is inwoked by pressing a button.
    /// </summary>
    public void Tips()
    {
        if (moneycounter.currentMoney - 25 < 0) return; //Checks if the current money is less than 25, if so return nothing.
        tUpgrade += 2; //Increments the tUpgrade by 2.
        moneycounter.currentMoney -= 25; //Decrements the current money by 25.
    }
}


      

