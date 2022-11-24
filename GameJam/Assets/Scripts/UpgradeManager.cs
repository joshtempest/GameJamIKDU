using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class UpgradeManager : MonoBehaviour
{

    public int pUpgrade;
    public int tUpgrade;

    //public GameObject TakeMoney;

//This function is inwoked by pressing the button
    public void CustomerPatience()

    {
        pUpgrade += 2;

    }

    public void Tips()

    {
        tUpgrade += 2;
    }


}


      

