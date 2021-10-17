using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string interactableTag = "Interactable";
    [SerializeField] private Text objectname;
    private Transform _selection;
    // Update is called once per frame
    
    void Update()
    {
        if (_selection != null){
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5)){
            var selection = hit.transform;
            
            if (selection.CompareTag(interactableTag)){
                var selectionRenderer = selection.GetComponent<Renderer>();
                
                if (selectionRenderer != null){
                    selectionRenderer.material = highlightMaterial;
                    objectname.text = selection.gameObject.name;
                }
                _selection = selection;
                
            }
            else {
                objectname.text = null;
            }
            
        }    
    }
}
