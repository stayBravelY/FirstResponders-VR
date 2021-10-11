using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycaster : MonoBehaviour
{
    private GameObject RaycastObj;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        

        if (Physics.Raycast(ray, out hit)) {
            Debug.DrawLine (ray.origin, hit.point, Color.red);
            print(hit.collider.gameObject.name);
            RaycastObj = hit.collider.gameObject;
            
            if (Input.GetKeyDown("e")) {
                Debug.Log("You've interacted with it");
                RaycastObj.SetActive(false);
            }
        }else
        {
            Debug.DrawLine (ray.origin, ray.origin + ray.direction * 10, Color.blue);
        }
       


    }

    
}
