using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailsManager : MonoBehaviour
{
    [SerializeField] GameObject details;
    
    void Update()
    {
        
    }
    public void showDetails(){
        details.SetActive(true);
    }

    public void hideDetails(){
        details.SetActive(false);
    }
}
