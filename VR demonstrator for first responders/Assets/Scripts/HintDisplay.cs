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
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3)){

            GameObject go = hit.collider.gameObject;
            var pick = go.GetComponentInChildren<PickUp>();
            
            if (go.CompareTag("Interactable")){
                Hint.SetActive(true);
                if (pick != null)
                {
                    Pick.SetActive(true);
                }
            }

        }else
        {
            Hint.SetActive(false);
            Pick.SetActive(false);
        }
    }
}
