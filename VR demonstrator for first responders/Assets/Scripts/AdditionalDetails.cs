using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalDetails : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject detailsUI;
    public GameObject mainUI;
    // Start is called before the first frame update
  public void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3)){
            if (Input.GetKeyDown(KeyCode.E))
            {   
                if (GamePaused)
                {
                    Resume();
                }else
                {
                    Pause();
                }
            }
        }
    }
   public void Resume()
    {
        detailsUI.SetActive(false);
        mainUI.SetActive(true);
        Time.timeScale = 1f;
        GamePaused = false;
    
    }
    public void Pause()
    {
        detailsUI.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
