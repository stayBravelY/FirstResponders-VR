using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDisplay : MonoBehaviour
{
    public GameObject Hint;
    public GameObject Pick;

    // Update is called once per frame
    void Update()
    {
        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;//RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3)){

            GameObject go = hit.collider.gameObject;
           
            var canvas = go.GetComponentInChildren<DetailsManager>();
            
            if (go.CompareTag("Interactable")){
                if (canvas != null)
                {
                   Hint.SetActive(true); 
                }
             }   
               
        if (Physics.Raycast(ray, out hit, 1))
            {
            GameObject pickable = hit.collider.gameObject;
            var pick = pickable.GetComponentInChildren<PickUp>();
            if (pickable.CompareTag("Interactable")){
                
                if (pick != null)
                {
                    Pick.SetActive(true);
                }
            }
            }
            

        }else
        {
            Hint.SetActive(false);
            Pick.SetActive(false);
        }
    }
}
