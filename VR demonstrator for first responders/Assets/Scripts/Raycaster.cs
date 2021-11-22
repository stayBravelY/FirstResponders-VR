using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Raycaster : MonoBehaviour
{
    private GameObject RaycastObj;
    List<InfoManager> infos = new List<InfoManager>();
    List<DetailsManager> details = new List<DetailsManager>();

    void Start() {
        infos = FindObjectsOfType<InfoManager>().ToList();
        details = FindObjectsOfType<DetailsManager>().ToList();
    }
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        

        if (Physics.Raycast(ray, out hit, 5)) {
            Debug.DrawLine (ray.origin, hit.point, Color.red);
            //print(hit.collider.gameObject.name);
            //RaycastObj = hit.collider.gameObject;
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("Interactable")){
                OpenInfo(go.GetComponent<InfoManager>());
                OpenDetail(go.GetComponent<DetailsManager>());
            }
            
        }else
        {
            Debug.DrawLine (ray.origin, ray.origin + ray.direction * 10, Color.blue);
            CloseAll();
        }
       
    

    }
    void OpenInfo(InfoManager desiredInfo){
        foreach (InfoManager info in infos) {
            if (info == desiredInfo){
                info.OpenInfo();
            }
            else{
                info.CloseInfo();
            }
        }
    }
    void CloseAll(){
        foreach (InfoManager info in infos) {
            info.CloseInfo();
        }
        foreach (DetailsManager detail in details){
            detail.hideDetails();
        }

    }

    void OpenDetail(DetailsManager desiredDetail){
        foreach (DetailsManager detail in details) {
            if (detail == desiredDetail){
                detail.showDetails();
            }
            else{
                detail.hideDetails();
            }
        }
    }

    

        

    
}
