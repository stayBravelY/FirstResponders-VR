using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfoManager : MonoBehaviour
{
    const float SPEED = 6f;
    [SerializeField]
    Transform InfoBox;

    Vector3 ChangedScale = Vector3.zero;


    // Update is called once per frame
    void Update()
    {
        InfoBox.localScale = Vector3.Lerp(InfoBox.localScale,ChangedScale, Time.deltaTime * SPEED);
    }

    public void OpenInfo(){
        ChangedScale = Vector3.one;
    }
    public void CloseInfo(){
        ChangedScale = Vector3.zero;
    }
}
