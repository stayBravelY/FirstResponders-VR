using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{


    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            Debug.DrawLine (ray.origin, hit.point, Color.red);
            print(hit.collider.gameObject.name);
        }else
        {
            Debug.DrawLine (ray.origin, ray.origin + ray.direction * 10, Color.blue);
        }
       


    }
}
