using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused; //Responsible for pausing/unpausing the game.

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            print("Escape key was pressed");
            PauseMenu();
        }
    }

    public void PauseMenu()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseMenu.SetActive(false);
            ResumeGame();
        }
        else if (!isPaused)
        {
            isPaused = true;
            pauseMenu.SetActive(true);
            PauseGame();
        }
    }

    //Pauses the game when called
    public void PauseGame()
    {
        Time.timeScale = 0f; //Stops the game
        isPaused = true;
        Debug.Log("Paused"); //Prints to console that the game is paused
    }
    
    //Unpauses the game when called
    public void ResumeGame()
    {
        Time.timeScale = 1f; //Resumes the game
        isPaused = false;
        Debug.Log("Resumed"); //Prints to console that the game has resumed
    }
}