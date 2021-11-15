using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeTimer : MonoBehaviour
{
    public Image img;
    public float totalTime = 2;
    bool status;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (status)
        {
            timer +=Time.deltaTime;
            img.fillAmount = timer / totalTime;
        }
        
    }
    public void GazeOn()
    {
        status = true;
    }

    public void GazeOff()
    {
        status = false;
        timer = 0;
        img.fillAmount = 0;
    }
}