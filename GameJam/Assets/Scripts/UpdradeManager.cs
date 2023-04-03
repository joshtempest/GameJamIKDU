using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class UpdradeManager : MonoBehaviour
{

//These are the variables that is referenced by the CustomerManager
    public int pUpgrade;
    public int tUpdate;

    //public GameObject 

//This function is inwoked by pressing the button
    public void CustomerPatience()

    {

        pUpgrade += 2;


    }

    public void Tips()

    {

        tUpdate += 2;

    }


}


      

