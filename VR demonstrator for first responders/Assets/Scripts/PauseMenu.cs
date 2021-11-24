using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pasueMenuUI;
    public GameObject mainUI;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            if (GamePaused)
            {
                Cursor.lockState = CursorLockMode.None;
                Resume();
            }else
            {   
               // Cursor.lockState = CursorLockMode.Locked;
                Pause();
            }
        }
       
            Cursor.lockState = CursorLockMode.Locked;

    }
   public void Resume()
    {
        pasueMenuUI.SetActive(false);
        mainUI.SetActive(true);
        Time.timeScale = 1f;
        GamePaused = false;
    
    }
    public void Pause()
    {
        pasueMenuUI.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
