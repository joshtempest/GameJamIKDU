using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScene : MonoBehaviour
{
    public static int totalDays;
    public static float totalEarnings;
    public TextMeshProUGUI totalDaysText;
    public TextMeshProUGUI totalEarningsText;

    private void Start()
    {
        totalDaysText.text = "Total days: " + totalDays;
        totalEarningsText.text = "Total earnings: " + totalEarnings;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("StartScene");
    }
}
