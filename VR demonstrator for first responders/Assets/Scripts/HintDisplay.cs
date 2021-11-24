using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDisplay : MonoBehaviour
{
     public GameObject Hint;


    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3)){

            GameObject go = hit.collider.gameObject;

            if (go.CompareTag("Interactable")){
                Hint.SetActive(true);
            }
        }else
        {
            Hint.SetActive(false);
        }
    }
}
