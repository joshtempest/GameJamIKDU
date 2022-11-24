using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class StartButton : MonoBehaviour
{
    
   void Button()
   {
    SceneManager.LoadScene("LoveSoup", LoadSceneMode.Single);
   }
}
