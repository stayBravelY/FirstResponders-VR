using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject pasueMenuUI;
    public GameObject mainUI;
    public GameObject Player;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            if (GamePaused)
            {
                //Cursor.lockState = CursorLockMode.None;
                Resume();
            }else
            {   
                //Cursor.lockState = CursorLockMode.Locked;
                Pause();
            }
        }
       
         //Cursor.lockState = CursorLockMode.Locked;

    }
   public void Resume()
    {
        pasueMenuUI.SetActive(false);
        mainUI.SetActive(true);
        Time.timeScale = 1f;
        GamePaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Player.GetComponentInChildren<MouseLook>().enabled = true;
    }
    void Pause()
    {
        if(Time.timeScale != 0){
        pasueMenuUI.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponentInChildren<MouseLook>().enabled = false;
        }
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void LoadMenu()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene("Menu");
    }
}
